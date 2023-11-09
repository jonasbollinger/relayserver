namespace Thinktecture.Relay.Connector;

internal static class LoggerEventIds
{
	// Group id's by class here, each class gets a 100 block. Just for convenience to be able
	// to insert new messages later on without having strange jumps within the events for one
	// class.
	public const int AccessTokenProviderRequestingAccessToken = 101;
	public const int AccessTokenManagementConfigureOptionsGotDiscoveryDocument = 102;
	public const int AccessTokenManagementConfigureOptionsErrorRetrievingDiscoveryDocument = 103;
	public const int AccessTokenManagementConfigureOptionsErrorTargetTypeNotFound = 104;
	public const int AccessTokenManagementConfigureOptionsCouldNotParseTimeout = 105;

	public const int RelayConnectorPostConfigureOptionsGotDiscoveryDocument = 201;

	public const int ClientRequestHandlerAcknowledgeRequest = 301;
	public const int ClientRequestHandlerErrorHandlingRequest = 302;
	public const int ClientRequestHandlerDeliverResponse = 303;

	public const int ClientRequestWorkerNoTargetFound = 401;
	public const int ClientRequestWorkerFoundTarget = 402;
	public const int ClientRequestWorkerRequestingBody = 403;
	public const int ClientRequestWorkerRequestingTarget = 404;
	public const int ClientRequestWorkerOutsourcingUnknownBody = 405;
	public const int ClientRequestWorkerOutsourcingBody = 406;
	public const int ClientRequestWorkerOutsourcedBody = 407;
	public const int ClientRequestWorkerOutsourcingBodyFailed = 408;
	public const int ClientRequestWorkerErrorOutsourcingBody = 409;
	public const int ClientRequestWorkerInlineBody = 410;
	public const int ClientRequestWorkerErrorDownloadingBody = 411;
	public const int ClientRequestWorkerRequestTimedOut = 412;
	public const int ClientRequestWorkerErrorProcessingRequest = 413;

	public const int RelayTargetRegistryRegisteredTarget = 501;
	public const int RelayTargetRegistryUnregisteredTarget = 502;
	public const int RelayTargetRegistryCouldNotUnregisterTarget = 503;

	public const int RelayWebTargetRequestingTarget = 601;
	public const int RelayWebTargetRequestedTarget = 602;
}
