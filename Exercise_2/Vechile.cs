using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Vechile : IDrivbale
    {
        public int Speed { get; set; }
        public string Name { get; set; }
        public int RemaningFuel { get; set; }

        public Vechile(string veichaleName)
        {
            this.Name = veichaleName;
        }

        public Vechile(string veichaleName, int speed) : this(veichaleName)
        {
            this.Speed = speed;
        }

        public static void TestDrive(Vechile vehicle)
        {
            vehicle.StartEngine();
            vehicle.Accelarate();
            vehicle.TurnLeft();
            vehicle.TurnRight();
            vehicle.Break();
            vehicle.StopEngine();
        }

        public void Accelarate()
        {
            Console.WriteLine($"{this.Name} is moving");
        }

        public void Break()
        {
            Console.WriteLine($"{this.Name} is stopping");
        }

        public void StartEngine()
        {
            Console.WriteLine($"{this.Name} is starting engine");
        }

        public void StopEngine()
        {
            Console.WriteLine($"{this.Name} is stopping engine");
        }

        public void TurnLeft()
        {
            Console.WriteLine($"{this.Name} is turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine($"{this.Name} is turning right");
        }
    }
}
