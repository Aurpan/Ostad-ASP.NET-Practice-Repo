namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car();
            Car mazda = new Car();

            toyota.Brand = "Toyota";
            toyota.Model = "Corolla";
            toyota.Year = 2020;
            toyota.Mileage = 15000;

            mazda.Brand = "Mazda";
            mazda.Model = "RX-8";
            mazda.Year = 2018;
            mazda.Mileage = 30000;

            toyota.Drive(1000);
            mazda.Drive(2000);
        }
    }
}
