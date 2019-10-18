using System;
using System.Collections.Generic;
using System.Text;
using CSharpDesignPatterns.Base;

namespace CSharpDesignPatterns.Builder
{
    public class MountainBikeDirector : BikeDirector
    {
        public override IBicycle Build(AbstractBikeBuilder builder)
        {
            builder.BuildHandleBars();
            builder.BuildWideTires();
            return builder.Bicycle;
        }
    }
}
