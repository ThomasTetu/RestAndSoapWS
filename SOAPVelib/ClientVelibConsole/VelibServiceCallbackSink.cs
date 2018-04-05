using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientVelibConsole.SOAPVelibReference;

namespace ClientVelibConsole
{
    class VelibServiceCallbackSink : SOAPVelibReference.IVelibOperationsCallback
    {
        public void GotStationData(string city, string station, Station result)
        {
            Console.WriteLine("City ...: {0}", city);
            Console.WriteLine("Station ...: {0}", station);
            Console.WriteLine("Available Bikes ......: {0}", result.availableBikes);
        }

        public void StationDataRetrieved()
        {
            Console.WriteLine("Station Data Succesfully Retrived ! ");
        }
    }
}
