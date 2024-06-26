using System;

namespace DragRace
{
    public class Tesla:ICar
    {
        private int _currentSpeed = 0;

        public void SlowDown()
        {
            _currentSpeed-=5;
        }

        public void SpeedUp()
        {
            _currentSpeed+=10;
        }

        public void StartEngine()
        {
            Console.WriteLine("Silence");
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