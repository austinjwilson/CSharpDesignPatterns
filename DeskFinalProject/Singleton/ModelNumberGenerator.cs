using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;
        private static object sychronizationRoot = new object();
        private long _count = 5793;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (Instance == null)
                {
                    lock (sychronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGenerator();
                        }
                    }
                    return instance;
                }




            }





        }
    }
}// end namespace
