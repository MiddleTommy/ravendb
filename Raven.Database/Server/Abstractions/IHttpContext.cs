using System.Security.Principal;

namespace Raven.Database.Server.Abstractions
{
	public interface IHttpContext
	{
		RavenConfiguration Configuration { get; }
		IHttpRequest Request { get; }
		IHttpResponse Response { get; }
		IPrincipal User { get; }
		void FinalizeResonse();
	}
}