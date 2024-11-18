using GloboClima.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GloboClima.Infrastructure.ExternalServices.Services
{
    public class ExternalWebApiService : IExternalWebApiService
    {
        public async Task<string> GetExternalData(string endpoint)
        {

            var client = new HttpClient();
            var res = await client.GetAsync(endpoint);

            if (res.StatusCode != HttpStatusCode.OK)
                throw new Exception();

            return await res.Content.ReadAsStringAsync();
        }
    }
}
