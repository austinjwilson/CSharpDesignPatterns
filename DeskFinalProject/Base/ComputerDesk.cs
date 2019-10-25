using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class ComputerDesk : AbstractDesk
    {
        public DeskShape UShaped { get; private set; }

        private DeskShape lampwith2USBBuiltInPorts;
        private DeskShape deskShape;

        public override decimal Price { get; } = 1515.00m;
        public override string ModelNumber { get; } = "CO9014";
        public new object Serial { get; }

        //public override decimal Price => throw new NotImplementedException();

        public ComputerDesk(FrameType frame, DeskShape shape, SurfaceTop top)
            :base(frame, shape, top)
        {
            
        }

        public ComputerDesk()
            :this(FrameType.wood,DeskShape.UShaped,SurfaceTop.wood)
        {
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.Computer);
        }




    } // end class
} // end namespace
