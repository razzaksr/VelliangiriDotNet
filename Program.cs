using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Modular operator
            Int16 yet=90,wet=65;
            Console.WriteLine(yet/3);
            Console.WriteLine(wet%3); */

            // Denominations matches

            Int32 actual=0,required=0,_2000s=4, _500s=8,_200s=10,_100s=10, count=0;
            String denom="";

            Int32 available=(_2000s*2000)+(_500s*500)+(_200s*200)+(_100s*100);

            Console.WriteLine("Enter the amount: ");
            actual=Int32.Parse(Console.ReadLine());//3000
            required=actual;

            if(required<=available)
            {
                Console.WriteLine("Can be withdrawn");
                count=required/2000;// 3000%2000>>1
                if(count<=_2000s)
                {
                    _2000s-=count;// 4-1>>3
                    required-=(count*2000);// 3000=3000-2000;>>1000
                    denom+="2000 X "+count+"\n";
                }
                else
                {
                    required-=(_2000s*2000);
                    denom+="2000 X "+_2000s+"\n";
                    _2000s=0;
                }
                if(required>0)
                {
                    count=required/500;// 3000%500>>1
                    if(count<=_500s)
                    {
                        _500s-=count;// 4-1>>3
                        required-=(count*500);// 3000=3000-2000;>>1000
                        denom+="500 X "+count+"\n";
                    }
                    else
                    {
                        required-=(_500s*500);
                        denom+="500 X "+_500s+"\n";
                        _500s=0;
                    }
                }
                if(required>0)
                {
                    count=required/200;// 3000%500>>1
                    if(count<=_200s)
                    {
                        _200s-=count;// 4-1>>3
                        required-=(count*200);// 3000=3000-2000;>>1000
                        denom+="200 X "+count+"\n";
                    }
                    else
                    {
                        required-=(_200s*200);
                        denom+="200 X "+_200s+"\n";
                        _200s=0;
                    }
                }
                if(required>0)
                {
                    count=required/100;// 3000%500>>1
                    if(count<=_100s)
                    {
                        _100s-=count;// 4-1>>3
                        required-=(count*100);// 3000=3000-2000;>>1000
                        denom+="100 X "+count+"\n";
                    }
                    else
                    {
                        required-=(_100s*100);
                        denom+="100 X "+_100s+"\n";
                        _100s=0;
                    }
                }
                if(required>0)
                {
                    Console.WriteLine(actual+" not match with denominations");
                }
                else
                {
                    Console.WriteLine("Denomination for the required cash\n"+denom);
                }
            }
            else{
                Console.WriteLine("Insifficient amount in machine "+available);
            }


        }
    }   
}
