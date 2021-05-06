using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            // left upper floyd
            for(int row=1;row<=5;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            // right upper floyd
            for(int row=1;row<=5;row++)
            {
                for(int spc=5-1;spc>=row;spc--)
                {
                    Console.Write(" ");
                }
                for(int col=1;col<=row;col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }
            // upper pascal
            for(int row=1;row<=5;row++)
            {
                for(int spc=5-1;spc>=row;spc--)
                {
                    Console.Write(" ");
                }
                for(int col=1;col<=row;col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            // upper pyramid
            int limit=1;
            for(int row=1;row<=5;row++)
            {
                for(int spc=5-1;spc>=row;spc--)
                {
                    Console.Write(" ");
                }
                for(int col=1;col<=limit;col++)
                {
                    Console.Write("$");
                }
                limit+=2;Console.WriteLine();
            }
            // Patterns
            /* for(int row=1;row<=5;row++)
            {
                for(int col=1;col<=5;col++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

            String alpha="Mohamed";
            /* for(int row=1;row<alpha.Length;row++)
            {
                Console.WriteLine(alpha);
            } 
            for(int row=1;row<=alpha.Length;row++)
            {
                for(int col=0;col<alpha.Length;col++)
                {
                    Console.Write((int)alpha[col]+" ");
                }
                Console.WriteLine();
            } */
        }
    }   
}
