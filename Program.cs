using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] react)
        {

            /*
            Jagged array/Array inside array
            type[][] var=new type[row][]
            var[0]=new type[]{}
            var[1]=new type[]{}
            */

            String[][] cast=new string[3][];
            cast[0]=new string[]{"Hiddleson","Elezabeth","Jhnson"};
            cast[1]=new string[]{"Pratt","Evans","Scarlet","Elan"};
            cast[2]=new string[]{"Robert","Holland"};

            foreach(String[] row in cast)
            {
                foreach(String elem in row)
                {
                    Console.Write(elem+" ");
                }
                Console.WriteLine();
            }

            /*
            type[] var={v1,v2,v3,v1,v2,v3};
            type[row,col] var={{v1,v2,v3},{v1,v2,v3},{v1,v2,v3}};
            type[row,col] var=new type[rowsize,colsize];
            */

            /* 
            double[,] yet={{1.9,4.5,0.7},{9.2,0.1,15.6},{0.009,3.05,2.09},{6.1,21.6,9.2}};
            for(int row=0;row<4;row++)
            {
                for(int select=0;select<3;select++)
                {
                    for(int com=select+1;com<3;com++)
                    {
                        if(yet[row,select]>yet[row,com])
                        {
                            yet[row,select]*=yet[row,com];
                            yet[row,com]=yet[row,select]/yet[row,com];
                            yet[row,select]/=yet[row,com];
                        }
                    }
                }
            }
            
            for(int row=0;row<4;row++)
            {
                for(int col=0;col<3;col++)
                {
                    Console.Write(yet[row,col]+" ");
                }
                Console.WriteLine();
            }
 */
            /* 
            double[,] yet={{1.9,4.5,0.7,3.1},{9.2,4.2,0.1,15.6},{0.009,3.05,6.12,2.09},{6.1,3.4,21.6,9.2}};
            Console.WriteLine("Tell us value wish to search: ");
            double value=Double.Parse(Console.ReadLine());
            int row=0;
            while(row<4)
            {
                int col=0;
                while(col<4)
                {
                    if(yet[row,col]==value)
                    {
                        Console.WriteLine(value+" exists @ "+row+" and "+col);
                        return;
                    }
                    col++;
                }
                row++;
            }
 */
            /* 
            String[,] fav=new String[2,5];
            for(int row=0;row<2;row++)
            {
                Console.WriteLine("Tell us top 5 in "+(row+1)+" genere");
                for(int col=0;col<5;col++)
                {
                    Console.WriteLine("Tell us top 5's "+(col+1)+" movie: ");
                    fav[row,col]=Console.ReadLine();
                }
            }

            foreach(String mov in fav)
            {
                Console.WriteLine(mov);
            }
 */
            /* int[,] doors={{3,6,4},{6,2,5},{4,9,1}};
            Console.WriteLine("Length of array: "+doors.Length);
            for(int row=0;row<3;row++)
            {
                for(int col=0;col<3;col++)
                {
                    Console.Write(doors[row,col]+" ");
                }
                Console.WriteLine();
            } */
        }
    }   
}
