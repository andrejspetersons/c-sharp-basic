using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<Radio> radioList = new List<Radio>
            {
                new Radio(),
                new Radio(),
                new Radio(),
                new Radio(),
                new Radio(),
                new Radio(),
            };

            List<Parrot> parrotList = new List<Parrot>
            {
                new Parrot(),
                new Parrot(),
                new Parrot(),
                new Parrot(),
                new Parrot(),
                new Parrot(),
            };

            for (int i = 0; i < radioList.Count; i++)
            {
                radioList[i].PlaySound();
            }

            for (int i = 0; i < parrotList.Count; i++)
            {
               parrotList[i].PlaySound();
            }


        }
    }
}