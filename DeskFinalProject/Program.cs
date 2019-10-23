using DeskFinalProject.Base;
using System;
using DeskFinalProject.Singleton;

namespace DeskFinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            FloatingDesk();
            SitStandDesk();
            ComputerDesk();
            RollTop();
            ExecutiveDesk();
            Test();
        }

        static void Test()
        {
            
            Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.SitStand));
            Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.RollTop));
            Console.WriteLine("next serial" + CPUGenerator.Instance.NextCPU(DeskType.Floating));


        }

        static void ExecutiveDesk()
        {

        }
        static void RollTop()
        {

        }
        static void ComputerDesk()
        {

        }

        static void SitStandDesk()
        {

        }


        static void FloatingDesk()
        {
            IDesk myDesk = new FloatingDesk();

            //Console.WriteLine("This desk has a built in credenza with 3 compartments and 2 shelves.");
        }
    }
}
