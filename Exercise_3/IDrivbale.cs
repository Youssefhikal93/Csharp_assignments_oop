using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    interface IDrivbale
    {
        string Name { get; set; }
        int Speed { get; set; }
        int RemainingFuel { get; set; }

        //void StartEngine();
        //void StopEngine();
        //void TurnRight();
        //void TurnLeft();
        void Accelarate();
        void Break();
        
    }
}
