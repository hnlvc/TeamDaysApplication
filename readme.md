# Application as a Software Engineer in Professional Service
Hey, thanks a lot for taking the time reviewing this code. 

## Build and run the application
You might have seen that, `TeamDaysApplication.App` does not contain an `appsettings.json` file. 
You need to add that and besides the auto-generated content, the file should contain a section for the fulfillmenttools API:
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

**A:** Good question, I know Google if offering a .NET SDK and gives examples on how to write a function in .NET. I am more experienced in testing
APIs locally, so this was the quickest solution presenting my working style. In productive environments I love using event-triggered Cloud functions such
as Google Functions or ServiceBus-triggered Azure Functions

**Q: Why .NET?**

**A:** The .NET 6 and 7 is the eco-system I am most experienced in. 

**Q: Why did you store the API credentials in the appsettings?**

**A:** I don't have an testing environment on GCP or Azure, so Secret Managers and Key Vaults were no option I was able to use. So this
was the quickest way to get that app running.
