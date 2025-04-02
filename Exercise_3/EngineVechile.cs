using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
   abstract class EngineVechile
    {
        private int _remainingFuel;
        private int _speed;

        public virtual int RemainingFuel
        {
            get { return _remainingFuel; }
            set { _remainingFuel = value; }
        }

        public virtual int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public EngineVechile()
        {
            this.Speed =0;
            this.RemainingFuel = 0;
        }
    }
}
