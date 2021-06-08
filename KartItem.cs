using System;
namespace Projects
{
    class KartItem
    {
        String name, brand;
        int cost;

        public void Look()
        {
            Console.WriteLine(this.brand+" "+this.name+" "+this.cost);
        }
    }
}