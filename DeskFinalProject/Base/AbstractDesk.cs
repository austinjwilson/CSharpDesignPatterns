using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public abstract class AbstractDesk : IDesk
    {
        
        private readonly FloatingDesk desk;

        public abstract decimal Price { get; }
        public FrameType MaterialType { get; private set; }
        public DeskShape GetShape { get; private set; }
        public string Serial { get; private set; }
        public SurfaceTop Surface { get; protected set; }
        public object AddFeature { get => ((IDesk)desk).AddFeature; set => ((IDesk)desk).AddFeature = value; }

        public object AddSurfaceTop => ((IDesk)desk).AddSurfaceTop;

        public object AddFrame => ((IDesk)desk).AddFrame;

        public object AddFeatures => ((IDesk)desk).AddFeatures;

        public abstract string ModelNumber { get; }

        public AbstractDesk(FrameType frame, DeskShape shape, SurfaceTop top)
        {
            MaterialType = frame;
            GetShape = shape;
            Surface = top;
        }

        protected AbstractDesk(DeskShape getShape)
        {
            GetShape = getShape;
        }

      

        public virtual void Features()
        {
            Console.WriteLine("This desk can have an additional ");
        }

        public virtual void Credenza()
        {
            Console.WriteLine("This credenza has 3 drawers and 4 wooden doors");
        }

        public AbstractDesk()
        {
            
        }


        //public AbstractDesk(FloatingDesk desk)
            //: this(FloatingDesk.WireManagementContainer, desk) { }

        //protected AbstractDesk(FrameType wireManagementContainer, FloatingDesk desk)
        //{
            //this.wireManagementContainer = wireManagementContainer;
            //this.desk = desk;
        //}
    } // end class
     
} // end namespace

