using System;

namespace ExceptionHandling
{
    class FiniteChances
    {
        Double[] term={3.4,12.9,5.6,0.9,3.3,11.5,9.2,4.1};
        int index, limit=1;
        public void fetch()
        {
            try{
                index=Int32.Parse(Console.ReadLine());
                Console.WriteLine("extracted value is "+term[index]);
            }
            catch(IndexOutOfRangeException ind)
            {
                Console.WriteLine(ind);
                if(limit<3)
                {
                    limit++;
                    fetch();
                }
                else{Console.WriteLine("maximum attempt reached");}
            }
        }
    }
}