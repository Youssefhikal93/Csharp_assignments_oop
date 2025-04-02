namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mistubishi = new Car("Lancer");
            mistubishi.RemainingFuel = 80;
            mistubishi.Speed = 150;
            mistubishi.Accelarate();
            mistubishi.Accelarate();
            mistubishi.Break();


            Bus scania = new Bus("Scania");

            //scania.Accelarate();

        }
    }
}
