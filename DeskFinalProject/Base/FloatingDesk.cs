using System;
using System.Collections.Generic;
using System.Text;
using DeskFinalProject.Singleton;

namespace DeskFinalProject.Base
{
    public class FloatingDesk : IDesk
    {
        
        public decimal Price { get; } = 75.00m;
        public FrameType MaterialType { get ;  }
        public DeskShape GetShape { get; }
        public FloatingDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = shape;
        }

        public FloatingDesk()
        {
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 3 compartments and 2 shelves");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

    }
}

