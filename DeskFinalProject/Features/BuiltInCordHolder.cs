using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public class BuiltInCordHolder : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 25.00m; }
        }

        public BuiltInCordHolder(IDesk desk)
            : base(desk) { }
    } // end class 
} // end namespace
