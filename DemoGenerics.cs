using System;

namespace Projects
{
    class DemoGenerics<T>
    {
        public T alpha;

        public DemoGenerics(){}

        public DemoGenerics(T data)
        {
            alpha=data;
        }

        public void display()
        {
            Console.WriteLine(alpha);
        }
    }
}