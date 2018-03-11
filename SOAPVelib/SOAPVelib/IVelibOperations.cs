using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    [ServiceContract]
    public interface IVelibOperations
    {
        [OperationContract]
        IList<String> GetStations(String city);

        [OperationContract]
        int GetNbAvailableBikes(String city,String station);
    }
}
