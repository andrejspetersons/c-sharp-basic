using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    internal interface ICar
    {
        void SpeedUp();
        void SlowDown();
        void StartEngine();
        string ShowCurrentSpeed();
    }
}
