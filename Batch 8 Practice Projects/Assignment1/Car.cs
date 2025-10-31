namespace Assignment1
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }


        public void Drive(int km)
        {
            Mileage += km; // Mileage = Mileage + km
            Console.WriteLine($"Car {Brand} {Model} has driven {Mileage} km."); // string interpolation
            //Console.WriteLine("Car " + Brand + " " + Model + " " + "has driven " + Mileage + " " + "km.");
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage} ");
        }
    }
}
