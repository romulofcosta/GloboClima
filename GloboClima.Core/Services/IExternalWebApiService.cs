using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboClima.Core.Services
{
    public interface IExternalWebApiService
    {
        public Task<string> GetExternalData(string endpoint);
    }
}
