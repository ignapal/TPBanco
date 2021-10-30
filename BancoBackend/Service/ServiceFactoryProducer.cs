using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service
{
    public class ServiceFactoryProducer
    {
        public static AbstractServiceFactory GetFactory(){
            return new ServiceFactoryImpl();
        }
    }
}
