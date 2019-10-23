using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class ComputerDesk : IDesk
    {
        private DeskShape ushape;
        private SurfaceTop wood;

        public decimal Price { get; } = 1515.00m;
        public FrameType MaterialType { get; }
        public DeskShape GetShape { get; }
        public object SerialNumbers { get; private set; }
        public object Serial { get; }

        public ComputerDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = (ushape = shape);
        }

        public ComputerDesk()
        {
            Serial = CPUGenerator.Instance.NextCPU(DeskType.Computer);
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 3 drawers and 4 wooden doors");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public ComputerDesk(DeskShape ushape)
        {
            this.ushape = ushape;
        }

        public ComputerDesk(SurfaceTop Wood)
        {
            this.wood = Wood;
        }


    } // end class
} // end namespace
