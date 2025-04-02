using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public interface IDrivbale
    {
        string Name { get; set; }
        int Speed { get; set; }
        int RemaningFuel { get; set; }

        void StartEngine();
        void StopEngine();
        void Accelarate();
        void Break();
        void TurnRight();
        void TurnLeft();



    }
}