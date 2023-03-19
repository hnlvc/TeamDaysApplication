using System.Net.Http.Json;
using System.Text.Json;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi;
using TeamDaysApplication.Domain.Models.GoogleAuthApi;

namespace TeamDaysApplication.Infrastructure.HttpClients;

public class GoogleAuthApiClient
{
    private static readonly HttpClient HttpClient = new();
    private static readonly JsonSerializerOptions WebOptions = new(JsonSerializerDefaults.Web); 
    
    public async Task<GoogleAuthJwtResponse?> GetAuthorizationDataAsync(FulfillmenttoolsCredentials fftCredentials, CancellationToken cancellationToken)
    {
        var requestBody = new
        {
            email = fftCredentials.Username,
            password = fftCredentials.Password,
            returnSecureToken = true
        };
        
        var response = await HttpClient.PostAsJsonAsync($"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={fftCredentials.ApiKey}", requestBody, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error while receiving Google Auth token with status code {response.StatusCode}");
        }

        return await response.Content.ReadFromJsonAsync<GoogleAuthJwtResponse>(WebOptions, cancellationToken);
    }

}