using System;
using System.Reflection;
delegate int velliangiri(double hai);
namespace Projects
{
    class Program//:Term
    {
        public static int angular(double tmp)
        {
            return (int)tmp/2;
        }
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
            DemoGenerics<int> demo=new DemoGenerics<int>();
            demo.alpha=200;demo.display();

            DemoGenerics<string> demo1=new DemoGenerics<string>("Annamalai");
            demo1.display();


            /* 
            DemoReflections reflections=new DemoReflections();
            reflections.Contact=876567877676L;reflections.Name="Velliangiri";
            reflections.Experience=4;

            DemoReflections reflections2=new DemoReflections(){Name="Sabarinathan",Contact=8765456783L,Experience=12};

            Type type=reflections.Name.GetType();

            Console.WriteLine(type);

            Console.WriteLine(type.BaseType);

            Console.WriteLine(type.Assembly);

            Console.WriteLine(type.Namespace);

            //type=reflections.Contact.GetType();
            type=Program.west.GetType();

            FieldInfo[] farray=type.GetFields(BindingFlags.Public|BindingFlags.Default|BindingFlags.NonPublic);

            foreach(FieldInfo tmp in farray)
            {
                Console.WriteLine(tmp);
            } */

            /* 
            //delegates demo
            velliangiri vel=new velliangiri(DemoDelegates.fetch);
            Console.WriteLine(vel(400.4));
            Console.WriteLine(vel(900.4));

            vel=new velliangiri(DemoDelegates.update);
            Console.WriteLine(vel(900.9));

            vel=new velliangiri(Program.angular);
            Console.WriteLine(vel(8999.3)); */

            /* Console.WriteLine((int)stats.velliangiriks);
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
            } */
            
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
