using MediatR;
using TeamDaysApplication.Core.Queries.Orders;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.StrippedOrder;
using TeamDaysApplication.Infrastructure.HttpClients;

namespace TeamDaysApplication.Core.UseCases;

public class GetAllOrdersUseCase : IRequestHandler<GetAllOrdersQuery, StrippedOrdersResponse?>
{
    private readonly FulfillmenttoolsCredentials _fftCreds;
    private readonly GoogleAuthApiClient _googleAuthApiClient;
    private readonly FulfillmenttoolsTeamDaysApiClient _fulfillmenttoolsApiClient;

    public GetAllOrdersUseCase(FulfillmenttoolsCredentials fftCreds, GoogleAuthApiClient googleAuthApiClient, FulfillmenttoolsTeamDaysApiClient fulfillmenttoolsApiClient)
    {
        _fftCreds = fftCreds;
        _googleAuthApiClient = googleAuthApiClient;
        _fulfillmenttoolsApiClient = fulfillmenttoolsApiClient;
    }

    public async Task<StrippedOrdersResponse?> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var googleAuthCreds = await _googleAuthApiClient.GetAuthorizationDataAsync(_fftCreds, cancellationToken);
        if (googleAuthCreds is null)
        {
            throw new ArgumentException("Authorization failed");
        }

        return await _fulfillmenttoolsApiClient.GetStrippedOrdersByIdAsync(googleAuthCreds.IdToken, cancellationToken);
    }
}