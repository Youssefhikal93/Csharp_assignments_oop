using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Car :Vechile
    {
        public Car(string name) : base(name)
        {

        }

        public Car(string name, int speed) : base(name, speed)
        {

        }
    }
}
