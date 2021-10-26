using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Service
{
    abstract class AbstractServiceFactory
    {
       public abstract IService GetService(string service);
    }
}
