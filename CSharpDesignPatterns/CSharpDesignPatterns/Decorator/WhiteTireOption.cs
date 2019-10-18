using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Decorator
{
    public class WhiteTireOption : AbstractBikeOption
    {
        public override decimal Price
        {
            get { return decoratedBike.Price + 80.00m; }
        }

        public WhiteTireOption(IBicycle bicycle)
        
            : base(bicycle) { }
        

    }
}
