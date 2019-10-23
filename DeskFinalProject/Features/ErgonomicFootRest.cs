using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public class ErgonomicFootRest : AbstractDeskOption
    {
        public override decimal Price
        {
            get { return featuredDesk.Price + 35.00m; }
        }

        public ErgonomicFootRest(IDesk desk)
            : base(desk) { }
    }
}
