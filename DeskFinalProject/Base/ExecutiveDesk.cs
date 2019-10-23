using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    class ExecutiveDesk : IDesk
    {
        private DeskShape Rectangle;
        private DeskShape rectangle;
        private object composite;

        public decimal Price { get; } = 1515.00m;
        public FrameType MaterialType { get; }
        public DeskShape GetShape { get; }
        public string Serial { get; private set; }

        public ExecutiveDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = (Rectangle = shape);
        }

        public ExecutiveDesk()
        {
            Serial = CPUGenerator.Instance.NextCPU(DeskType.Executive);
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 6 compartments and 6 drawers");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public ExecutiveDesk(DeskShape rectangle)
        {
            this.rectangle = rectangle;
        }

        public ExecutiveDesk(SurfaceTop Composite)
        {
            this.composite = composite;
        }
    } // end class
} // end namespace
