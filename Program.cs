using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] react)
        {
            String alpha="zealous";// literal way
            String beta=new String("zEAlous");// non-literal way
            //Class object=dynamic_m/y Constructor(value)

            Console.WriteLine(alpha==beta);

            beta=beta.ToLower();// Immutability
            Console.WriteLine(beta);

            Console.WriteLine(alpha.CompareTo(beta));
            Console.WriteLine(beta.Equals(alpha));

            beta="  zealous academy salem   ";
            Console.WriteLine(beta.Length+" "+alpha.Length);
            beta=beta.Trim();
            Console.WriteLine(beta.Length);

            Console.WriteLine(alpha[2]);
            Console.WriteLine(beta.Substring(4,10));// fromindex, no of chars

            Console.WriteLine(beta.GetHashCode());
            Console.WriteLine(alpha.Contains("alo"));
            Console.WriteLine(beta.Contains("alem"));

            beta=beta.Replace("salem","of career");

            Console.WriteLine(beta);

            Console.WriteLine(alpha.StartsWith("Ze"));
            Console.WriteLine(beta.EndsWith("er"));

            Console.WriteLine(alpha+" tech corp");
            alpha+=" tech corp";
            Console.WriteLine(alpha);
        }
    }   
}
