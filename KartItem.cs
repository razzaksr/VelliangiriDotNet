using System;
namespace Projects
{
    class KartItem
    {
        public String name, brand;
        public int cost;

        public void Look()
        {
            Console.WriteLine(this.brand+" "+this.name+" "+this.cost);
        }
    }
}