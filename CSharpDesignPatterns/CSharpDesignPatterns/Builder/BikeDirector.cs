using CSharpDesignPatterns.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Builder
{
    public abstract class BikeDirector
    {
        public abstract IBicycle Build(AbstractBikeBuilder builder);
    }
}
