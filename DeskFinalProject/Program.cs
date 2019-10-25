using DeskFinalProject.Base;
using System;
using DeskFinalProject.Singleton;
using DeskFinalProject.Features;
using DeskFinalProject.Facade;

namespace DeskFinalProject
{
    public class Program
    {
        public static DeskShape LampwithTwoUSBBuiltInPorts { get; private set; }

        static void Main(string[] args)
        {
            FloatingDesk();
            SitStandDesk();
            ComputerDesk();
            RollTop();
            Executive();
            OrderTaker taker = new OrderTaker();
            taker.BeginOrder();
           
            //Test();
            //Features();
        }
        static void Executive()
        {
            ExecutiveDesk myexecutive = new ExecutiveDesk();
            Displayinfo(myexecutive.Price, myexecutive.MaterialType,
                myexecutive.Surface, myexecutive.GetShape);

        }
        static void Features()
        {
           
        }

        private static void floatingDesk()
        {
            
        }

        static void Test()
        {
            
            //Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.SitStand));
           // Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.RollTop));
            //Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.Floating));


        }

       
        static void RollTop()
        {
            RollTopDesk myrolltop = new RollTopDesk();
            Displayinfo(myrolltop.Price, myrolltop.MaterialType,
                myrolltop.Surface, myrolltop.GetShape);
            //Console.WriteLine("This desk has a price of " + myrolltop.Price);
            //Console.WriteLine("This frame is " + myrolltop.MaterialType);
            //Console.WriteLine("This surface top is " + myrolltop.Surface);
            //Console.WriteLine("This desk is " + myrolltop.GetShape + " shaped.");
            Console.WriteLine("This credenza has 6 compartments and 6 drawers");
        }


        static void ComputerDesk()
        {
           ComputerDesk mycomputer = new ComputerDesk();
            Displayinfo(mycomputer.Price, mycomputer.MaterialType,
                 mycomputer.Surface, mycomputer.GetShape);
            Console.WriteLine("This credenza has 4 wooden doors and 3 drawers");
        }

        static void SitStandDesk()
        {
            SitStandDesk mysitstand = new SitStandDesk();
            Displayinfo(mysitstand.Price, mysitstand.MaterialType,
                mysitstand.Surface, mysitstand.GetShape);
            Console.WriteLine("This has no credenza");
        }


        static void FloatingDesk()
        {
            FloatingDesk myfloating = new FloatingDesk();
            Displayinfo(myfloating.Price, myfloating.MaterialType,
                myfloating.Surface, myfloating.GetShape);
            Console.WriteLine("This credenza is built in and has 3 composite" +
                " compartments and 2 shelves");
        }

        static void Displayinfo(decimal price, FrameType material, SurfaceTop surface, DeskShape shape) 
        {
            Console.WriteLine("This desk has a price of " + price);
            Console.WriteLine("This frame is " + material);
            Console.WriteLine("This surface top is " + surface);
            Console.WriteLine("This desk is " +shape + " shaped.");
        }

        
    } // end class
} // end namespace
