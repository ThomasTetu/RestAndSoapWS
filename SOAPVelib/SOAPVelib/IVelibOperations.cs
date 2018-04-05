using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    [ServiceContract(CallbackContract = typeof(IVelibOperationsEvents))]
    public interface IVelibOperations
    {
        [OperationContract]
        IList<String> GetStations(String city);

        [OperationContract]
        IList<String> GetContracts();

        [OperationContract]
        void GetStationData(String city,String station);

        [OperationContract]
        void SubscribeGetStationDataEvent();

        [OperationContract]
        void SubscribeGetStationDataEventFinished();
    }
}
