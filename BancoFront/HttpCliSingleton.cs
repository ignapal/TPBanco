using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BancoFront
{
    class HttpCliSingleton
    {
        private static HttpCliSingleton instancia;
        private HttpClient httpClient;

        private HttpCliSingleton() {
            httpClient = new HttpClient();
        }

        public static HttpClient GetClient() {
            if (instancia == null) {
                instancia = new HttpCliSingleton();
            }
            return instancia.httpClient;
        }
    }
}
