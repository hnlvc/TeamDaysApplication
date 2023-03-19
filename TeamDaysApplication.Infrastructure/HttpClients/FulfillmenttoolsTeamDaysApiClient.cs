using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;

namespace TeamDaysApplication.Infrastructure.HttpClients;

public class FulfillmenttoolsTeamDaysApiClient
{
    private static readonly HttpClient HttpClient = new ();
    private static readonly JsonSerializerOptions WebOptions = new(JsonSerializerDefaults.Web);

    public FulfillmenttoolsTeamDaysApiClient(string apiUrl)
    {
        HttpClient.BaseAddress = new Uri(apiUrl);
    }

    public async Task<StrippedOrdersResponse?> GetStrippedOrdersByIdAsync(string jwt,
        CancellationToken cancellationToken)
    {
        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);

        var response = await HttpClient.GetAsync($"api/orders", cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error while fetching data from the api with status code {response.StatusCode}");
        }

        return await response.Content.ReadFromJsonAsync<StrippedOrdersResponse>(WebOptions, cancellationToken);
    }
}