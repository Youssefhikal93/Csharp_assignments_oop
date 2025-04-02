using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Car :Vechile
    {

        public Car (string name):base(name) 
        {
            this.Accelerating = 20;
            this.TankCapcity = 60;
            this.MaxSpeed = 120;
            this.MinFuel = 10;
        }
    }
}
