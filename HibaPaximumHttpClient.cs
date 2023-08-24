using System.Dynamic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

namespace HiBaPaximum;

public class HibaPaximumHttpClient
{
    private static readonly HttpClient httpClient;
    static HibaPaximumHttpClient()
    {
        httpClient = new HttpClient();
    }

    public static HibaPaximumHttpClient Create()
    {
        return new HibaPaximumHttpClient();
    }

    public async Task<TResponse> ExecuteAsync<TRequest, TResponse>(TRequest model, ActionFields actionFields)
    {
        var endpointUrl = GetEndpoint(model);
        var requestMessage = new HttpRequestMessage
        {
            Content = JsonContent.Create(model),
            Method = HttpMethod.Post,
            RequestUri = new Uri(actionFields.ServerAddress + endpointUrl, UriKind.Absolute)
        };

        if (!string.IsNullOrEmpty(actionFields.Token))
        {
            requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", actionFields.Token);
        }

        var responseMessage = await httpClient.SendAsync(requestMessage).ConfigureAwait(false);
        var response = await responseMessage.Content.ReadFromJsonAsync<TResponse>().ConfigureAwait(false);

        dynamic logContent = new ExpandoObject();
        logContent.Endpoint = endpointUrl;
        logContent.Request = model;
        logContent.Response = response;
        WriteLog(logContent);
        return response;
    }

    private string GetEndpoint<T>(T model)
    {
        var modelType = model.GetType();
        var propEndpoint = modelType.GetProperties().ToList().FirstOrDefault(x => x.Name == "EndpointUrl");
        if (propEndpoint == null)
        {
            throw new NotSupportedException();
        }
        var propValue = propEndpoint.GetValue(model);
        if (propValue == null)
        {
            throw new NotSupportedException();
        }
        return propValue.ToString();
    }

    private void WriteLog(dynamic content)
    {
        var jsonStr = JsonSerializer.Serialize(content);
        var dateFolder = DateTime.Now.ToString("yyyyMMdd");
        if (!Directory.Exists("Logs/" + dateFolder))
        {
            Directory.CreateDirectory("Logs/" + dateFolder);
        }

        var actionInfo = content.Endpoint.ToString().Split('/');
        var serviceName = actionInfo[actionInfo.Length - 2];
        var actionName = actionInfo[actionInfo.Length - 1];
        var fileName = "Logs/" + dateFolder + "/" + serviceName + "-" + actionName + "-" + Guid.NewGuid() + ".json";
        File.WriteAllText(fileName, jsonStr);
    }
}

public record HttpLogContent(string EndPoint, string Request, string Response);