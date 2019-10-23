using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    class WireManagementContainer : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 50.00m; }
        }

        public WireManagementContainer(IDesk desk)
            : base(desk) { }
    } // end class
} // end namespace
