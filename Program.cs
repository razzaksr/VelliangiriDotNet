using System;

namespace Projects
{
    class Program
    {
        public static int Binary(double[] yet,int start,int end, double value)
        {
            int mid=(start+end)/2;
            if(yet[mid]==value)
                return mid;
            else if(yet[mid]>value)
                return Binary(yet,start,mid,value);
            else if(yet[mid]<value)
                return Binary(yet,mid+1,end,value);
            else
                return -1;
        }
        static void Main(string[] react)
        {
            double[] exp={0.4,1.9,4.5,6.1,7.3,8.10,12.4};
            Console.WriteLine("Tell us value wish to find its position: ");
            double data=Double.Parse(Console.ReadLine());
            int pos=Program.Binary(exp,0,exp.Length-1,data);
            Console.WriteLine(data+" exists @ "+pos);
        }
    }   
}
