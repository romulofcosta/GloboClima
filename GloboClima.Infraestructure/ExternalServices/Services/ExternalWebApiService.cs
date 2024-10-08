using GloboClima.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
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

            return await res.Content.ReadAsStringAsync();
        }
    }
}
