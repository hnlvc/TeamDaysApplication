using AutoMapper;
using MediatR;
using TeamDaysApplication.Core.Commands;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi;
using TeamDaysApplication.Domain.Models.FulfillmenttoolsApi.CreateOrder;
using TeamDaysApplication.Infrastructure.HttpClients;

namespace TeamDaysApplication.Core.UseCases;

public class CreateShipFromStoreOrderUseCase : IRequestHandler<CreateShipFromStoreOrderCommand>
{
    private readonly FulfillmenttoolsCredentials _fftCreds;
    private readonly GoogleAuthApiClient _googleAuthApiClient;
    private readonly FulfillmenttoolsTeamDaysApiClient _fulfillmenttoolsApiClient;
    private readonly IMapper _mapper;

    public CreateShipFromStoreOrderUseCase(FulfillmenttoolsCredentials fftCreds, 
        GoogleAuthApiClient googleAuthApiClient, FulfillmenttoolsTeamDaysApiClient fulfillmenttoolsApiClient, IMapper mapper)
    {
        _fftCreds = fftCreds;
        _googleAuthApiClient = googleAuthApiClient;
        _fulfillmenttoolsApiClient = fulfillmenttoolsApiClient;
        _mapper = mapper;
    }

    public async Task Handle(CreateShipFromStoreOrderCommand request, CancellationToken cancellationToken)
    {
        var authorizationCredentials = await _googleAuthApiClient.GetAuthorizationDataAsync(_fftCreds, cancellationToken);
        if (authorizationCredentials is null)
        {
            throw new ArgumentException("Authorization failed");
        }

        var shipFromStoreOrderRequest = _mapper.Map<CreateShipFromStoreOrderRequestModel>(request.Contract);

        await _fulfillmenttoolsApiClient.CreateShipFromStoreOrderAsync(authorizationCredentials.IdToken,
            shipFromStoreOrderRequest, cancellationToken);
    }
}