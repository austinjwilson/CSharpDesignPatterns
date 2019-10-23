using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public abstract class AbstractDesk : IDesk
    {
        public abstract decimal Price { get; }
        public FrameType MaterialType { get; private set; }
        public DeskShape GetShape { get; }
        public string Serial { get; private set; }

        public AbstractDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = shape;
        }

        protected AbstractDesk(DeskShape getShape)
        {
            GetShape = getShape;
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has ");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

    } // end class
     
} // end namespace

