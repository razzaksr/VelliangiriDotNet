using System;
namespace Projects
{
    class Program//:Term
    {
        /* public override int read(string desired)
        {
            for(int pos=0;pos<tech.Length;pos++)
            {
                if(desired.Equals(tech[pos]))
                {
                    return pos;
                }
            }
            return -1;
        } */
        //non abstract method/ method with body{}
        //public void greet(){Console.WriteLine("Beta Wishes you lot!");}
        static void Main(string[] react)
        {
            Console.WriteLine((int)stats.velliangiriks);
            Console.WriteLine((int)stats.noobmaster);

            Console.WriteLine("Iterating all players");

            foreach(String names in Enum.GetNames(typeof(stats)))
            {
                Console.WriteLine(names);
            }

            Console.WriteLine("Iterating all player's rank");

            foreach(stats s in Enum.GetValues(typeof(stats)))
            {
                Console.WriteLine((int)s);
            }
            
            //Group group=new Group("New India",340,new DateTime(2018,01,26));
            //Console.WriteLine(group);
            
            
            //Term term=new Program();
            /* Program term=new Program();
            term.traverse();
            term.greet();
            Console.WriteLine(term.read("DJango")); */
        }
    }

    abstract class Term
    {
        protected String[] tech={"Spring","Hibernate","JUnit","Mockito","DJango","Flask","React"};
        public void traverse()
        {
            foreach(String tmp in tech){Console.WriteLine(tmp);}
        }

        public abstract int read(String desired);
    }
}
