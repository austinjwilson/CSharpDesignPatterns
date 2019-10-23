using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    class PowerStrip : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 25.00m; }
        }

        public PowerStrip(IDesk desk)
            : base(desk) { }
    } // end class
} // end namespace
