using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] yet)
        {
            

            //selection sort            
            /* 
            double[] yet={8.9,12.5,0.2,5.6,7.9,3.4,5.9,1.3,12.1,4.4};
            for(int hold=0;hold<yet.Length;hold++)
            {
                for(int com=hold+1;com<yet.Length;com++)
                {
                    if(yet[hold]<yet[com])
                    {
                        yet[hold]*=yet[com];
                        yet[com]=yet[hold]/yet[com];
                        yet[hold]/=yet[com];
                    }
                }
            } 
            foreach(double tmp in yet)
            {
                Console.Write(tmp+" ");
            }
            */

            //bubble sort
            /* String third;
            Console.WriteLine("Bubble sorting will be done");
            for(int times=0;times<yet.Length-1;times++)
            {
                for(int bub=0;bub<yet.Length-times-1;bub++)
                {
                    if(yet[bub].CompareTo(yet[bub+1])>0)
                    {
                        third=yet[bub];
                        yet[bub]=yet[bub+1];
                        yet[bub+1]=third;
                    }
                }
            }
            foreach(String tmp in yet)
            {
                Console.Write(tmp+" ");
            } */
            /* 
            //command line argument
            Console.WriteLine(args.Length);
            String name=args[0];
            String skill=args[1];
            int exp=Int32.Parse(args[2]);
            float ctc=float.Parse(args[3]);
            Int64 contact=Int64.Parse(args[4]);
            Console.WriteLine("Dear "+name+", Thanks for applying the job with following Skillset "+skill+", experience of "+exp+", current ctc of "+ctc+". The application confirmation has sent as SMS to your mobile "+contact); */
        }
    }   
}
