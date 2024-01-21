using System;

namespace DragRace
{
    public class Bmw:ICar
    {
        private int _currentSpeed = 0;

        public void SlowDown()
        {
            _currentSpeed -= 5;
        }

        public void SpeedUp()
        {
            _currentSpeed += 15;
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrr.....");
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