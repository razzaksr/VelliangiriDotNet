using System;
namespace ExceptionHandling
{
    class InFiniteChances
    {
        Double[] term={3.4,12.9,5.6,0.9,3.3,11.5,9.2,4.1};
        Random random=new Random();
        int index;
        public void extract()
        {
            try{
                index=random.Next(50);
                Console.WriteLine("extracted value is "+term[index]);
            }
            catch(IndexOutOfRangeException ind)
            {
                Console.WriteLine(ind);
                extract();
            }
        }
    }
}