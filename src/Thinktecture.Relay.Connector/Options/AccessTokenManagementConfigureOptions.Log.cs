using System;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Thinktecture.Relay.Connector.Options;

internal partial class AccessTokenManagementConfigureOptions
{
	private static partial class Log
	{
		// Methods with destructuring parameters aren't supported by the LoggerMessage generator yet
		// See https://github.com/dotnet/runtime/issues/69490 which should be fixed in .NET 7+
		private static readonly Action<ILogger, Uri, OpenIdConnectConfiguration, Exception?> LoggerGotDiscoveryDocument
			= LoggerMessage.Define<Uri, OpenIdConnectConfiguration>(LogLevel.Trace,
				LoggerEventIds.AccessTokenManagementConfigureOptionsGotDiscoveryDocument,
				"Got discovery document from {DiscoveryDocumentUrl} ({@DiscoveryDocument})");

		public static void GotDiscoveryDocument(ILogger logger, Uri discoveryDocumentUrl,
			OpenIdConnectConfiguration discoveryDocument)
		{
			if (logger.IsEnabled(LogLevel.Trace))
			{
				LoggerGotDiscoveryDocument.Invoke(logger, discoveryDocumentUrl, discoveryDocument, null);
			}
		}

		[LoggerMessage(LoggerEventIds.AccessTokenManagementConfigureOptionsErrorRetrievingDiscoveryDocument,
			LogLevel.Error,
			"An error occured while retrieving the discovery document from {DiscoveryDocumentUrl}")]
		public static partial void ErrorRetrievingDiscoveryDocument(ILogger logger,
			Exception exception, Uri discoveryDocumentUrl);
	}
}
