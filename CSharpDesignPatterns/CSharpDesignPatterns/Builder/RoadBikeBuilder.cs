using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public class RoadBikeBuilder : AbstractBikeBuilder
    {
        /* Class object of AbstractRoadBike is assigned by the constructor 
         and retrieved by the property Bicycle*/
        private AbstractRoadBike _roadBikeInProgress;

        /* Property of RoadBikeBuilder used to return an object of IBicycle.
         This object is of type AbstractRoadbike that implements the IBicycle
         interface*/
        public override IBicycle Bicycle
        {get { return _roadBikeInProgress; } }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }

            // Methods below are overriden from the AbstractBikeBuilder
        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handle Bars");        
        }
    }
}

