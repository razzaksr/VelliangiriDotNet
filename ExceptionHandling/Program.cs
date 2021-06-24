﻿using System;

namespace ExceptionHandling
{
    class Program
    {
        //static Wind wind;
        static void Main(string[] args)
        {
            Console.WriteLine("Fuel milage calculation");
            Int32 liter=0,km=0, milage=0;
            try{
                liter=Int32.Parse(Console.ReadLine());
                km=Int32.Parse(Console.ReadLine());
                milage=(km/liter);
                Console.WriteLine("Milage of "+liter+" for "+km+" is "+milage);
            }
            catch(FormatException form)
            {
                Console.WriteLine(form);
                Console.WriteLine("Input has to be whole numbers");
                liter=Int32.Parse(Console.ReadLine());
                km=Int32.Parse(Console.ReadLine());
                milage=(km/liter);
                Console.WriteLine("Milage of "+liter+" for "+km+" is "+milage);
            }
            catch(DivideByZeroException zero)
            {
                Console.WriteLine(zero);
                Console.WriteLine("Liter must be valid except 0");
                liter=Int32.Parse(Console.ReadLine());
                milage=(km/liter);
                Console.WriteLine("Milage of "+liter+" for "+km+" is "+milage);
            }
            /* try{
                wind.replace(9.9,1);
                Console.WriteLine(wind);
            }
            catch(NullReferenceException re)
            {
                Console.WriteLine(re);
                wind=new Wind();// initalization
                wind.replace(9.9,1);
                Console.WriteLine(wind);
            }
            finally
            {
                Console.WriteLine("Wind accessed in proper manner");
            } */
        }
    }
    class Wind
    {
        Double[] meters={4.5,9.2,5.9,12.9,5.6,3.1,2.9,7.1,8.90};
        public void replace(double yet,int pos)
        {
            meters.SetValue(yet,pos);
        }
        public override string ToString()
        {
            String hai="";
            foreach(Double tmp in meters)
            {
                hai+=tmp+" ";
            }
            return hai;
        }
    }
}
