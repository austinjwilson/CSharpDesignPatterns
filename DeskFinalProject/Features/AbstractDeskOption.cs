using DeskFinalProject.Base;
using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Features
{
    public abstract class AbstractDeskOption : AbstractDesk
    {
        protected internal IDesk featuredDesk;
        public AbstractDeskOption(IDesk desk)
            : base(desk.GetShape)
        {
            this.featuredDesk = desk;
        }

    } // end class
} // end namespace
