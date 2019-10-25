using DeskFinalProject.Base;
using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Facade
{
    public class Reciept 
    {
        private IDesk desk;

        public Reciept(IDesk desk)
        {
            this.desk = desk;
        }

        //internal void TrackingUPCNumber()
        //{
           
        //}

        //internal void PrintUPCNumber()
        //{
           
        //}

        public static void PrintReciept(IDesk desk)
        {
            Console.WriteLine("Printing Reciept...");
        }
    } // end class
} // end class
