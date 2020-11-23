using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Thinktecture.Relay.Transport;

namespace Thinktecture.Relay.Server.Transport
{
	/// <summary>
	/// A context containing processing information and data for one relay task.
	/// </summary>
	/// <typeparam name="TRequest">The type of request.</typeparam>
	/// <typeparam name="TResponse">The type of response.</typeparam>
	public interface IRelayContext<TRequest, TResponse>
		where TRequest : IClientRequest
		where TResponse : ITargetResponse
	{
		/// <summary>
		/// The unique id of the request.
		/// </summary>
		Guid RequestId { get; }

		/// <summary>
		/// The client request.
		/// </summary>
		TRequest ClientRequest { get; set; }

		/// <summary>
		/// The target response.
		/// </summary>
		/// <remarks>Setting this to an instance in an interceptor prevents requesting any target by default.</remarks>
		/// <seealso cref="ForceConnectorDelivery"/>
		TResponse TargetResponse { get; set; }

		/// <summary>
		/// Indicates if at least one connector is available for processing the <see cref="ClientRequest"/>.
		/// </summary>
		bool ConnectorAvailable { get; }

		/// <summary>
		/// Indicates that regardless of an already available <see cref="TargetResponse"/> the <see cref="ClientRequest"/> should be send
		/// to a connector for further processing by a target (ignoring the results).
		/// </summary>
		bool ForceConnectorDelivery { get; set; }

		/// <summary>
		/// One or more <see cref="IAsyncDisposable"/> which needs to be disposed at the end of the request.
		/// </summary>
		IList<IAsyncDisposable> ResponseDisposables { get; }

		/// <summary>
		/// The <see cref="HttpContext"/>.
		/// </summary>
		HttpContext HttpContext { get; }
	}
}
