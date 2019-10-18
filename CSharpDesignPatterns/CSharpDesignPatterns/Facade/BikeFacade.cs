using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Facade
{
    public class BikeFacade
    {
        public void PrepareForSale(IBicycle bicycle)
        {
            Regristration reg = new Regristration(bicycle);
            reg.AllocateBikeNumber();

            Documentation.PrintBrochure(bicycle);

            bicycle.CleanFrame();
            bicycle.AirTires();
            bicycle.TestRide();
        }
    }
}
