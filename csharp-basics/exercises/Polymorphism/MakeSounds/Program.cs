using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> itemSounds = new List<ISound>
            {
                new Firework(),
                new Radio(),
                new Parrot(),
                new Firework(),
                new Radio(),
                new Parrot(),
                new Firework(),
            };

            for (int i = 0; i < itemSounds.Count; i++)
            {
                itemSounds[i].PlaySound();
            }
        }
    }
}