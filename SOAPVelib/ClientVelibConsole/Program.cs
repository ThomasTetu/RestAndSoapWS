using ClientVelibConsole.SOAPVelibReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientVelibConsole
{
    class Program
    {
        private static string HELP = "\nQ : Exit the program\n" +
                                     "City : Get the list of all cities\n" +
                                     "Station <City> : Get the list of stations of a city\n" +
                                     "Bike <City> <Station> : Get the number of available bikes of the specified station\n";
                            
        public static void Main(string[] args)
        {
            SOAPVelibReference.VelibOperationsClient client = new VelibOperationsClient();
            while (true)
            {
                Console.Write("Type ? for help\n");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "?":
                        Console.Write(HELP);
                        break;
                    case "q":
                        System.Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }         
        }
    }
}
