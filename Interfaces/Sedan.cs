﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Sedan : CarBase, IGPS, ITurbo
    {
        public Sedan(string make, string model, string color, int mileage, Driver driver, Tire[] tires) 
           : base(make, model, color, mileage, driver, tires)
        {
        }

        public bool HasSpareTire { get; set; }

        public override void Brake()
        {
            Console.WriteLine("...puh");
        }

        public override void Honk()
        {
            Console.WriteLine("beep!");
        }

        public void GoFaster()
        {
            Console.WriteLine("JANE STOP THIS CRAZY THING!!!");
        }

        public void Navigate()
        {
            Console.WriteLine("Finding Faster Route, you can maybe get away with speeding");
        }
    }
}
