using GloboClima.Core.Services;
using System.Net;

namespace GloboClima.Infrastructure.ExternalServices.Services
{
    public class ExternalWebApiService : IExternalWebApiService
    {
        public async Task<HttpResponseMessage> GetExternalData(string endpoint)
        {
			try
			{
                return await new HttpClient().GetAsync(endpoint);
            }
			catch (Exception)
			{
				throw; 
			}
        }
    }
}
