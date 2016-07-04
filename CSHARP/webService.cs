using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Web;
using Cliente.wsMate;

namespace Cliente
{
    public class webService : wsMate.wsPublico
    {
        [return: MessageParameter(Name = "return")]
        public multiplicarResponse multiplicar(multiplicarRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<multiplicarResponse> multiplicarAsync(multiplicarRequest request)
        {
            throw new NotImplementedException();
        }

        [return: MessageParameter(Name = "return")]
        public sumarResponse sumar(sumarRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<sumarResponse> sumarAsync(sumarRequest request)
        {
            throw new NotImplementedException();
        }
    }
}