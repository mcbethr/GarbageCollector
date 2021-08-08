using System;
using System.Collections.Generic;

namespace GarbageCollector
{
    class Program
    {
        static void Main(string[] args)
        {

            DummyObject GlobalDummy = new DummyObject(10);

            for (int i =0;i<1;i++)
            {
                DummyObject DummyInFor = new DummyObject(10);
            }

            //You want to see something on the Large Object Heap?
            //Uncomment the text below!
            /*
            List<DummyObject> DummyObjects = new List<DummyObject>();

            for (int i = 0; i < 10; i++)
            {
                DummyObjects.Add(new DummyObject(100000));
            }
            */
        }

    }


    public class DummyObject
    {
        private string DummyString;

        public DummyObject(int loop)
        {
            //Don't do this.
            for (int i = 0; i < loop; i++)
            {
                DummyString += "Data";
            }
        }

    }


}
