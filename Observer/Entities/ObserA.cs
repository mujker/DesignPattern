﻿using System;
using Observer.Interface;

namespace Observer.Entities
{
    public class ObserA : IObserable, IDisplay
    {
        public void Update(string s1, string s2, string s3)
        {
            Console.WriteLine($"ObserA Update:{s1} {s2} {s3}");
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"ObserA Display");
        }
    }
}