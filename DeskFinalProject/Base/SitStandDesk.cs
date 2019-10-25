using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class SitStandDesk : AbstractDesk
    {
        private DeskShape LShape;
        private FrameType metal;

        public override decimal Price { get; } = 625.00m;
        public override string ModelNumber { get; } = "STS9039";
        public FrameType MaterialType { get; }
        public DeskShape GetShape { get; }
        public SurfaceTop Glass { get; }

        public SitStandDesk(FrameType frame, DeskShape shape, SurfaceTop top)
            : base(frame, shape, top)
        {

        }

        public SitStandDesk()
            : this(FrameType.metal, DeskShape.LShaped, SurfaceTop.glass)
        { 

        }
        //public SitStandDesk()
        //{
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.Computer);
        //}

        public virtual void Credenza()
        {
            Console.WriteLine("This has no credenza");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        

    } // end class
} // end namespace
