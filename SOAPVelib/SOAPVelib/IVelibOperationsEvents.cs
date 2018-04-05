using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    interface IVelibOperationsEvents
    {

        [OperationContract(IsOneWay = true)]
        void GotStationData(String city, String station, Station result);

        [OperationContract(IsOneWay = true)]
        void StationDataRetrieved();
    }
}
