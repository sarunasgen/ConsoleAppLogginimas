using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLogginimas
{
    public class CarsService
    {
        private List<string> Cars { get; set; }
        public CarsService()
        {
            Cars = new List<string>();
            Log.Information("Cars service started");
        }
        public void AddCar(string car)
        {
            if (!string.IsNullOrEmpty(car))
            {
                Cars.Add(car);
                Log.Information("Car was added to the list: " + car);
            }
            else
                Log.Error("Car was not added because it was null or empty value");

        }
        public void RemoveCar(string car)
        {
            Log.Debug("Car to delete " + car);
            if(Cars.Remove(car))
            {
                Log.Information("Car was successfully removed");
            }
            else
            {
                Log.Error("Car was not removed, because it was not present in the list");
            }
        }
    }
}
