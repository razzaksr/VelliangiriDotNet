using System;

namespace Files
{
    [Serializable]
    class Game
    {
        public String Name{set;get;}
        public String Device{set;get;}
        public String Org{set;get;}
        public Double Size{set;get;}
        public Boolean isCostLess{set;get;}
    }
}