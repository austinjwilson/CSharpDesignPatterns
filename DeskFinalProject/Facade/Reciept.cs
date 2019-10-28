using DeskFinalProject.Base;
using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Facade
{
    public class Reciept 
    {
        private List<AbstractDesk> _Desks;
        private IDesk desk;

        //public Reciept(IDesk desk)
        //{
            //this.desk = desk;
        //}
        public Reciept(List<AbstractDesk>desks)
        {
            this._Desks = desks;

            string recieptTitle = "Reciept";
            string titleFormat = string.Format("{0,9}", recieptTitle);
            Console.WriteLine(titleFormat);
            Console.WriteLine();

            Title();
        }

        private void Title()
        {
            Console.WriteLine();
            string title = "ANPCO Manufacturing Inc";
            string address = "1740 Paseo Blvd";
            string city = "Kansas City, MO";
            string titleFormat = string.Format("{0, 30}", title);
            string addressFormat = string.Format("{0, 17}", address);
            string cityFormat = string.Format("{0,28}", city);
            Console.WriteLine(titleFormat);
            Console.WriteLine(addressFormat);
            Console.WriteLine(cityFormat);
            Console.WriteLine();
            DataHeaders();
        }

        private void DataHeaders()
        {
            Console.WriteLine();
            string data = string.Format("{0,5} {1,25} {2,35} {3,30}",
            "Quantity ", "Model # ", "Desk Type ", "Price");
            Console.WriteLine(data);
            Console.WriteLine();
            Console.WriteLine();
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
