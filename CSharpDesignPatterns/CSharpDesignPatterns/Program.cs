using CSharpDesignPatterns.AbstractFactory;
using CSharpDesignPatterns.Adapter;
using CSharpDesignPatterns.Base;
using CSharpDesignPatterns.Builder;
using CSharpDesignPatterns.Decorator;
using CSharpDesignPatterns.Facade;
using CSharpDesignPatterns.Singleton;
using System;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //AbstractFactoryDemo();
            //BuilderPatternDemo();
            //SingletonPatternDemo();
            //AdapterPatternDemo();
            //DecoratorPatternDemo();
            FacadePatternDemo();
        }

        static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Vintage(BikeColor.Green, new NarrowWheel(20)));
        }

        static void DecoratorPatternDemo()
        {
            IBicycle myMountainBike = new CrossCountry(new WideWheel(30));
            Console.WriteLine(myMountainBike);

            myMountainBike = new CustomGripOption(myMountainBike);
            Console.WriteLine(myMountainBike);

            myMountainBike = new LeatherSeatOption(myMountainBike);
            Console.WriteLine(myMountainBike);
        }

        static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));
            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }

        static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine(" next serial "+generator.NextSerial);
            Console.WriteLine(" next serial "+SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine(" next serial "+generator.NextSerial);
        }

        static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new DownHill(BikeColor.Green,
                new WideWheel(24));
            AbstractBikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();

            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }

    }
}
