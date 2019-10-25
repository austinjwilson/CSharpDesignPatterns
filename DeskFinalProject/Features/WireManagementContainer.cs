using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public class WireManagementContainer : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 25.00m; }
        }

        public WireManagementContainer(IDesk desk)
            : base(desk) { }




    } // end class
} // end namespace