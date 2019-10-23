using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public class ErgonomicHandCushion : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 35.00m; }
        }

        public ErgonomicHandCushion(IDesk desk)
            : base(desk) { }

    } // end class
} // end namespace
