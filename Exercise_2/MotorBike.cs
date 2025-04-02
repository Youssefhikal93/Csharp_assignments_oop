using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class MotorBike : Vechile
    {

        public MotorBike(string name) : base(name)
        {

        }

        public MotorBike (string name, int speed):base(name,speed) 
        {
            
        }
    }
}
