using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Vechile :EngineVechile,IDrivbale
    {
        public string Name { get; set; }
        protected int MaxSpeed;
        protected int MinFuel;
        protected int TankCapcity;
        protected int Accelerating;

        public override int RemainingFuel
        
        {
        get { return base.RemainingFuel  ; }
        set {
                
                   base.RemainingFuel = value;
       
            }  
        }

        public int Speed
        {
            get { return base.Speed; }
            set
            {
                    base.Speed = value;

                  
            }
        }

        
        public Vechile (string name)
        {
            this.Name = name;
            

        }

       public void Accelarate()
        {


            Console.WriteLine($"Avilibale fuel now is {this.RemainingFuel} liters");
            Console.WriteLine($"Current speed is {(this.Speed>MaxSpeed ? $"{this.Speed} and it will be reduced to 120 km/h" : this.Speed)}");
            Console.WriteLine("..............Acclerating............");

            if (this.RemainingFuel <= MinFuel || this.RemainingFuel>TankCapcity)
            {
                Console.WriteLine($"\nRemainingFuel: {this.RemainingFuel} liters");
                Console.WriteLine($"Capticy for the fuel should be less than {TankCapcity} liters");
            }else
            {




            this.RemainingFuel -= this.MinFuel;
            this.Speed += this.Accelerating;
            Console.WriteLine($"Current fuel is {(this.RemainingFuel)} liters");
            Console.WriteLine($"Current speed is {(this.Speed > MaxSpeed ? MaxSpeed : this.Speed)} km/h\n\n\n");
            
            }

                   }

        public void Break()
        {
            Console.WriteLine("Breaking...");

            this.Speed -= this.Accelerating;

            Console.WriteLine($"Reducing the speed with {this.Accelerating} for {this.Name} , the current speed is {(this.Speed>MaxSpeed ? MaxSpeed- this.Accelerating : this.Speed)} km/h");
        }


    }
}
