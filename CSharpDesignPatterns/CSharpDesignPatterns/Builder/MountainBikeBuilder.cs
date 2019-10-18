using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class MountainBikeBuilder : AbstractBikeBuilder
    {
        private AbstractMountainBike _mountainBikeInProgress;

        public override IBicycle Bicycle
        { get { return _mountainBikeInProgress; } } 

        public MountainBikeBuilder(AbstractMountainBike bike)
        {
            this._mountainBikeInProgress = bike;
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handle Bars");
        }
    }
}
