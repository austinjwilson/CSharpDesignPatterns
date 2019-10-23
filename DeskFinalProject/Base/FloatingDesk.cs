using System;
using System.Collections.Generic;
using System.Text;
using DeskFinalProject.Singleton;

namespace DeskFinalProject.Base
{
    public class FloatingDesk : IDesk
    {
        private DeskShape rectangle;
        private SurfaceTop composite;

        public decimal Price { get; } = 75.00m;
        public FrameType MaterialType { get ;  }
        public DeskShape GetShape { get; }
        public string Serial { get; private set; }

        public FloatingDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = (rectangle = shape);
        }

        public FloatingDesk()
        {
            Serial = CPUGenerator.Instance.NextCPU(DeskType.Floating);
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 3 compartments and 2 shelves");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public FloatingDesk(DeskShape rectangle)
        {
            this.rectangle = rectangle;
        }

        public FloatingDesk(SurfaceTop Composite)
        {
            this.composite = Composite;
        }
    } // end class 
} // end namespace

