namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorBike hondaBike = new MotorBike("Honda Bike");
            Car bmw = new Car("BMW car");
            //hondaBike.Accelarate();
            //hondaBike.StartEngine();
            //hondaBike.TurnRight();
            //hondaBike.StopEngine();
            Vechile.TestDrive(hondaBike);
            Vechile.TestDrive(bmw);
        
        }
    }
}
