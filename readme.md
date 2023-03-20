# Software Engineering in PS Application 
Hey, thanks a lot for taking the time reviewing this code. To get this application up and running, 
your `appsettings.json` should contain a section for the fulfillmenttools Api: 

```json
    {
  "fulfillmenttoolsCreds": {
    "Username": "<EMAIL>",
    "Password": "<PASSWORD>",
    "ApiKey": "<APIKEY>",
    "Url": "https://<YOUR>.api.fulfillmenttools.com/"
  }
}
```

## Questions that might come up
**Q: Why is this an API, not a function?**

**A:** Good question. I know Google if offering a .NET SDK and gives examples on how to write a function in .NET. 
I decided using an API for this UseCase as I think it's more important getting an overview of my working style. 
In a productive environment, I would prefer using an event triggered function to import orders into the fulfillmenttools
platform. Furthermore, I don't have an testing environment on GCP. 

**Q: Why did you use .NET instead of TypeScript?**

**A:** My skills in .NET are way higher than my TypeScript skills which are nearly to zero, currently.

**Q: Why did you store the API credentials in the appsettings?**

**A:** As explained above, my goal was showing my engineering approach real quick. In production, 
I would have used GCP Secret Manager or Azure Key Vaults. 


## Issues I encountered
- This was the first full application I set up, took a bit figuring everything out
  - Registering MediatR in .NET 7 changed a bit
- Always getting `400 Bad Request` when sending requests to the fft API