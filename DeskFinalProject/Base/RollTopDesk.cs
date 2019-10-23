using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    class RollTopDesk
    {
        private DeskShape Rectangle;
        private DeskShape rectangle;
        private object wood;

        public decimal Price { get; } = 1899.00m;
        public FrameType MaterialType { get; }
        public DeskShape GetShape { get; }
        public string Serial { get; private set; }

        public RollTopDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = (Rectangle = shape);
        }

        public RollTopDesk()
        {
            Serial = CPUGenerator.Instance.NextCPU(DeskType.RollTop);
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This has 6 drawers and 6 compartments for a credenza");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public RollTopDesk(DeskShape rectangle)
        {
            this.rectangle = rectangle;
        }

        public RollTopDesk(SufaceTop Wood)
        {
            this.wood = wood;
        }


    } // end class
} // end namespace
