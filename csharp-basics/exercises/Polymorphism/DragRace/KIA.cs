using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    internal class KIA : ICar
    {
        private int _currentSpeed = 0;

    
        public void SlowDown()
        {
            _currentSpeed -= 3;
        }

        public void SpeedUp()
        {
            _currentSpeed += 12;
        }

        public void StartEngine()
        {
            Console.WriteLine("Vrvrvrooom");
        }

        public override string ToString()
        {
            return $"Current speed: {_currentSpeed}";
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }
    }
}
