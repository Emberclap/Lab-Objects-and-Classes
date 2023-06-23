using System.Reflection;

namespace _7._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string input = "";
            while ((input = Console.ReadLine())!= "end")
            {
                List<string> vehicleData = input
                    .Split("/")
                    .ToList();
                string type = vehicleData[0];
                string brand = vehicleData[1];
                string model = vehicleData[2];
                int value = int.Parse(vehicleData[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, value);
                    cars.Add(car);

                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    trucks.Add(truck);
                }

            }
            
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - { car.HorsePower}hp");
                }
            }
            if( trucks.Count > 0)
            {
            Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
    public class Truck
    {
        public Truck(string brand, string model, int value)
        {
            Brand = brand;
            Model = model;
            Weight = value;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public Car(string brand, string model, int value)
        {
            Brand = brand;
            Model = model;
            HorsePower = value;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class CatalogVehicle
    {
        public CatalogVehicle(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}