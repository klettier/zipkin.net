namespace Zipkin
{
	/// <summary>
	/// Union of standard + common custom 
	/// </summary>
	public enum PredefinedTag 
	{
		HttpHost,
		HttpMethod,
		HttpPath,
		SqlQuery,

		ClientSend,
		ClientRecv,
		ServerSend,
		ServerRecv,
		WireSend,
		WireRecv,
		ClientSendFragment,
		ClientRecvFragment,
		ServerSendFragment,
		ServerRecvFragment, 
		ClientAddr,
		ServerAddr,
		LocalComponent,
		Error
	}
}