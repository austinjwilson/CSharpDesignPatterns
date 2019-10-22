using DeskFinalProject.Base;
using System;
using DeskFinalProject.Singleton;

namespace DeskFinalProject
{
    public class Program
    {
        static void Main(string [] args)
        {
            FloatingDesk();
        }
        static void FloatingDesk()
        {
            IDesk myDesk = new FloatingDesk();

            //Console.WriteLine("This desk has a built in credenza with 3 compartments and 2 shelves.");
        }
    }
}
