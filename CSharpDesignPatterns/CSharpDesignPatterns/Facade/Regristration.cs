using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Facade
{
    public class Regristration 
    {
        private IBicycle _bicycle;

        public Regristration(IBicycle bike)
        {
            this._bicycle = bike;
        }

        public void AllocateBikeNumber()
        {
            Console.WriteLine("Allocating Bike Number");
        }

    }
}
