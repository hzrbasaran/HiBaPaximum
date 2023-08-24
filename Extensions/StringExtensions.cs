using System.Globalization;
using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string ToTitleCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;
        TextInfo textInfo = new CultureInfo("tr-TR", false).TextInfo;
        return textInfo.ToTitleCase(text.ToLower()).Replace("Empty", "");
    }
    public static string ReplaceTurkishChar(this string text)
    {
        return text.ToLower().Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i").Replace("ö", "o").Replace("ü", "u")
            .Replace("ş", "s");
    }
    public static string ToUrl(this string text)
    {
        string str = text.ToLower().ReplaceTurkishChar();
        str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
        str = Regex.Replace(str, @"\s+", " ").Trim();
        str = Regex.Replace(str, @"\s", "-");   
        return str;
    }
}