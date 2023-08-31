# Hiba Paximum Api Client
    ## Version 1.0.1
    1. Markup Price feature added !
```csharp
    searchRequest = new PriceSearchRequest()
        {
            MarkupPrice = new SearchMarkupPrice()
            {
                Currency = "EUR", Percent = 20
            }
        };
```
    ## Version 1.0.0
```csharp
    var searchRequest = new PriceSearchRequest()
        {
            CheckAllotment = true,
            CheckStopSale = true,
            GetOnlyDiscountedPrice = false,
            GetOnlyBestOffers = true,
            ProductType = ProductTypes.Hotel,
            Nationality = "TR",
            CheckIn = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"),
            Night = 3,
            Currency = "TRY",
            Culture = "tr-TR",
            ArrivalLocations = new List<ArrivalLocationItem>(){ new() {Id = "23501", Type = 2 } 
            },
            RoomCriteria = new List<RoomCriteria>(){new(){ Adult = 2, ChildAges = new List<int>()}}
        };
    HotelAction.Search(searchRequest, new ActionFields() { ServerAddress = "yourServerAddress", Token = "yourAuthToken" });
```