using System;

namespace DragRace
{
    public class Audi:ICar
    {
        private int _currentSpeed = 0;

        public void SlowDown()
        {
            _currentSpeed -= 8;
        }

        public void SpeedUp()
        {
            _currentSpeed += 5;
        }

        public void StartEngine()
        {
            Console.WriteLine("Brr-rr-rr-rr-rr");
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