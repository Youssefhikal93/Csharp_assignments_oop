using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Bus:Vechile
    {
        public Bus(string name):base(name)
        {
            this.Accelerating = 15;
            this.TankCapcity = 150;
            this.MaxSpeed = 160;
            this.MinFuel = 15;
        }
    }
}
