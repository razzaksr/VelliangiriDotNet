using System;


namespace Projects
{
    class DemoDelegates
    {
        private static double[] house={456.9,1200.4,879.3,900.9,2500.5,400.4,100.3,670.3};
        public static int fetch(double yet)
        {
            for(int pos=0;pos<house.Length;pos++)
            {
                if(house[pos]==yet)
                {
                    return pos;
                }
            }
            return -1;
        }

        public static int update(double wind)
        {
            for(int pos=0;pos<house.Length;pos++)
            {
                if(house[pos]==wind)
                {
                    Console.WriteLine("Tell us new value for "+pos+" index");
                    house[pos]=Double.Parse(Console.ReadLine());
                    return pos;
                }
            }
            return -1;
        }
    }
}