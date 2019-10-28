using DeskFinalProject.Base;
using System;
using System.Collections.Generic;
using System.Text;
using DeskFinalProject.Singleton;

namespace DeskFinalProject.Features
{
    public class MyDeskFeatures
    {
        public void MyDeskOptions()
        {
            List<ExecutiveDesk> myDeskList = new List<ExecutiveDesk>();
            myDeskList.Add (new List ("Two Built In USB Ports"+ "Power Strip"));

            List<RollTopDesk>myDeskList = new List<RollTopDesk>();
            myDeskList.Add(new List("Built In Cord Holder"));

            List<ComputerDesk> myDeskList = new List<ComputerDesk>();
            myDeskList.Add(new List("Lamp" + "Two Built In USB Ports"));
            myDeskList.Add(new AbstractDesk("Lamp"));
            myDeskList.Add(new AbstractDesk("Power Strip"));
            myDeskList.Add(new AbstractDesk("Two Built In USB Ports"));
            myDeskList.Add(new AbstractDesk("Wire management Container")); 

            foreach(AbstractDesk item in myDeskList)
            {
                Console.WriteLine(item.myexecutive + "," + item.TwoBuiltInUSBPorts);
                Console.WriteLine(item.myrolltop + "," + item.BuiltInCordHolder);
                Console.WriteLine(item.mycomputer + "," + item.Lamp);
                Console.WriteLine(item.mysitstand + "," + item.ergonomicfootrest + item.ergonomichandcushion);
                Console.WriteLine(item.myfloating + "," + item.wiremanagementcontainer);
            }

        }

        
        {

        }
    }
}
