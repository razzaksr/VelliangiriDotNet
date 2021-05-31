using System;

namespace Projects
{
    class Program
    {

        int[] data={56,90,12,4,310,5,78,18,6,23};
        public int findOut(int value)
        {
            Array.Sort(data);
            return Array.BinarySearch(data,0,data.Length,value);
        }
        static void Main(string[] react)
        {
            KartItem ki1=new KartItem();
            ki1.name="128gb otg pendrive";
            ki1.brand="Sandisk";
            ki1.cost=1344;
            
            KartItem ki2=new KartItem();
            ki2.name="Casuals";
            ki2.brand="Rebok";
            ki2.cost=2199;

            ki1.Look();
            ki2.Look();

            //Console.WriteLine(ki1.brand+" "+ki1.name+" "+ki1.cost);
            //Console.WriteLine(ki2.brand+" "+ki2.name+" "+ki2.cost);
            //Classname objectName=new Classname();
            /* Program program=new Program();
            foreach(int tmp in program.data)
            {
                Console.Write(tmp+" ");
            }
            Console.WriteLine("\nPosition of 18 is: "+program.findOut(18)); */
        }
    }   
}
