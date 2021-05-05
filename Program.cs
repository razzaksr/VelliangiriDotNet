using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int collection=0, seek=0, count=0;
            Console.WriteLine("Tell us which amount to find count: ");
            seek=Int32.Parse(Console.ReadLine());
            for(int street=1;street<=4;street++)
            {
                for(int house=1;house<=10;house++)
                {
                    Console.WriteLine("Tell us amount to donate: ");
                    int amt=Int32.Parse(Console.ReadLine());
                    collection+=amt;
                    if(amt==seek)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total collection for covid relief fund: "+collection);
            Console.WriteLine(count+" of person gave "+seek+" amount");
            /* int collection=0, max1=Int32.MinValue, max2=Int32.MinValue,max3=Int32.MinValue;
            for(int street=15;street<=18;street++)
            {
                for(int house=1;house<=10;house++)
                {
                    Console.WriteLine("Request to donate for relief fund for covid");
                    int amt=Int32.Parse(Console.ReadLine());
                    collection+=amt;
                    if(amt>max1)
                    {
                        max3=max2;
                        max2=max1;
                        max1=amt;
                    }
                    else if(amt>max2&&amt!=max1)
                    {
                        max3=max2;
                        max2=amt;
                    }
                    else if(amt>max3&&amt!=max1&&amt!=max2)
                    {
                        max3=amt;
                    }
                }
            }
            Console.WriteLine("Total collection for covid relief fund: "+collection);
            Console.WriteLine(max1+","+max2+","+max3+" is Top 3 maximum donations obtained"); */
            /* String chart="-------\n";
            for(int row=1;row<=5;row++)
            {
                chart+="|";
                for(int seats=1;seats<=4;seats++)
                {
                    Console.WriteLine("Bring the amount: ");
                    int amt=Int32.Parse(Console.ReadLine());
                    if(seats==3)
                    {
                        chart+=" ";
                    }
                    if(amt>=260)
                    {
                        Console.WriteLine("You can travel @ "+seats+" in "+row+" row");
                        chart+="$";
                    }
                    else{
                        Console.WriteLine("Insufficient to travel");
                        chart+="#";
                    }
                }
                chart+="|\n";
            }
            chart+="-------\n";
            Console.WriteLine(chart); */
        }
    }   
}
