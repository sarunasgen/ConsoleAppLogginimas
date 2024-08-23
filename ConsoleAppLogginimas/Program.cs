using ConsoleAppLogginimas;
using Serilog;

var log = new LoggerConfiguration()
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

Log.Logger = log;

CarsService cars = new CarsService();

while(true)
{
    Console.WriteLine("1. Add Car");
    Console.WriteLine("2. Remove Car");
    string entry = Console.ReadLine();
    switch(entry)
    {
        case "1":
            Console.WriteLine("Write car name: ");
            cars.AddCar(Console.ReadLine());
            break;
        case "2":
            Console.WriteLine("Write car name you want to remove: ");
            cars.RemoveCar(Console.ReadLine());
            break;
        case "0":
            Log.Information("Application Stopped");
            return;
        default:
            continue;
    }
}


