using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] transaction=new Int32[10];
            Int32 noOfDeb=0, charges=0;
            for(int index=0;index<transaction.Length;index++)
            {
                transaction[index]=Int32.Parse(Console.ReadLine());
                if((index-1)!=-1)
                {
                    if(transaction[index]<transaction[index-1])
                    {
                        noOfDeb++;
                    }
                }
            }
            if(noOfDeb>3)
            {
                charges=(noOfDeb-3)*20;
                transaction[transaction.Length-1]-=charges;
            }
            Console.WriteLine("Available balance : "+transaction[transaction.Length-1] );
            Console.WriteLine(charges+" has to pay for "+noOfDeb);

            /* Double[] wfh={4.5,12.5,0.9,4.2,3.1,15.6,19.1,2.8,0.9,5.9,1.8,6.9,10.5};
            Console.WriteLine("Tell us start range u wish to delete: ");
            Double start=Double.Parse(Console.ReadLine());
            Console.WriteLine("Tell us end range u wish to delete: ");
            Double end=Double.Parse(Console.ReadLine());
            for(int pos=0;pos<wfh.Length;pos++)
            {
                if(wfh[pos]>=start&&wfh[pos]<=end)
                {
                    wfh[pos]=0.0;
                }
                Console.Write(wfh[pos]+" ");
            } */
            /* double[] wfh={4.5,12.5,0.9,4.2,3.1,15.6,19.1,2.8,0.9,5.9,1.8,6.9,10.5};
            Array.Sort(wfh);
            foreach(double third in wfh)
            {
                Console.WriteLine(third);
            } */
            /* double[] wfh={4.5,12.5,0.9,4.2,3.1,15.6,19.1,2.8,0.9,5.9,1.8,6.9,10.5};
            foreach(double third in wfh)
            {
                Console.WriteLine(third);
            }
            for(int index=0;index<wfh.Length;index++)
            {
                if(wfh[index]>=7.1)
                {
                    wfh[index]-=(wfh[index]*0.020);
                }
                Console.WriteLine(wfh[index]);
            } */

            /* String[] team={"Kelly","Chrono","Alok","Evans","Downey","Holland","Jhonson","Wanda","Hemsworth","Pratt","Rusou","Hiddleson","Maxim","Hayato"};
            foreach(String third in team)
            {
                if(third.EndsWith('a')||third.EndsWith('e')||third.EndsWith('i')||third.EndsWith('o')||third.EndsWith('u'))
                {
                    Console.WriteLine(third);
                }
            } */
            /* Int16[] yet={89,90,4,45,12,67,41,91,38,45,10,8,4,18,49,51,62,12,87};
            Console.WriteLine("Tell us data to find in array: ");
            Int16 data=Int16.Parse(Console.ReadLine());
            //linear search
            for(int index=0;index<yet.Length;index++)
            {
                if(yet[index]==data)
                {
                    Console.WriteLine(data+" found @ "+index);
                    //break;
                }
            } */
        }
    }   
}
