using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    internal class Skoda:ICar,ILexus
    {
        private int _currentSpeed = 0;


        public void SlowDown()
        {
            _currentSpeed -= 3;
        }

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr");
        }

        public override string ToString()
        {
            return $"Current speed: {_currentSpeed}";
        }

        public string ShowCurrentSpeed()
        {
            return _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 35;
        }
    }
}
