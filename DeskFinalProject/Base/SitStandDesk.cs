using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class SitStandDesk : IDesk
    {
        private DeskShape LShape;

        public decimal Price { get; } = 625.00m;
        public FrameType MaterialType { get; }
        public DeskShape GetShape { get; }
        public string Serial { get; private set; }
        public SurfaceTop Glass { get; }

        public SitStandDesk(FrameType frame, DeskShape shape)
        {
            MaterialType = frame;
            GetShape = (LShape = shape);
        }

        public SitStandDesk()
        {
            Serial = CPUGenerator.Instance.NextCPU(DeskType.Computer);
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This has no credenza");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public SitStandDesk(DeskShape LShape)
        {
            this.LShape = LShape;
        }

        public SitStandDesk(SurfaceTop Glass)
        {
            this.Glass = Glass;
        }

    } // end class
} // end namespace
