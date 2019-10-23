using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public class Lamp : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 30.00m; }
        }

        public Lamp(IDesk desk)
            : base(desk) { }
    }
}
