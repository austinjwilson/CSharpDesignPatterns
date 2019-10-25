using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public class ExecutiveDesk : AbstractDesk
    {
        public override decimal Price { get; } = 1515.00m;
        public override string ModelNumber { get; } = "ED43500";
        //public FrameType MaterialType { get; }
        public string Serial { get; private set; }

        public ExecutiveDesk(FrameType frame, DeskShape shape, SurfaceTop top)
            : base(frame, shape, top)
        {

        }
        public ExecutiveDesk()
            : this(FrameType.composite, DeskShape.Rectangle, SurfaceTop.composite) 
        {
            
        }
        
        
            //Console.WriteLine(".");
            //Console.WriteLine("composite.");
            //Console.WriteLine(" rectangle shape.");
        

        //public ExecutiveDesk()
        //{
            //Serial = CPUGenerator.Instance.NextCPU(DeskType.Executive);
        //}

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 6 compartments and 6 drawers");
        }

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        
        
    } // end class
} // end namespace
