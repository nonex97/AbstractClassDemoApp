using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryItem book = new Book(); 
            book.ProductName = "A tale of Two Cities";

            Car car = new Car();

            Ubahn U3 = new Ubahn();
            U3.UbahnLine = "U3";
            U3.TypeOfPublicTransport = "Subway";

            PublicTransport U6 = new Ubahn();
            U6.TypeOfPublicTransport = "Subway";
            
            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }

    public abstract class PublicTransport : IFuel
    {
        public string TypeOfPublicTransport { get; set; }

        public void StartFueling()
        {
            // fueling for any type, but can be different
        }
    }

    public interface IFuel
    {
        void StartFueling();
    }

    public class Ubahn : PublicTransport
    {
        public string UbahnLine { get; set; }
    }
}
