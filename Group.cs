using System;

namespace Projects
{
    public struct Group
    {
        public String Name{set;get;}
        public Int32 Count{set;get;}
        public DateTime Started{set;get;}

        public Group(String name,Int32 count,DateTime started)
        {
            Name=name;
            Count=count;
            Started=started;
        }

        public override string ToString()
        {
            return Name+" "+Count+" "+Started.ToString()+"\n";
        }
    }
}