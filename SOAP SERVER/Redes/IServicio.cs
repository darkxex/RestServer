using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Redes
{
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
       string Rut(string r);
        [OperationContract]
        string Nombre(string NOMBRES, string AP_PATERNO, string AP_MATERNO, string G);
    }
}
