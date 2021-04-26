using System;

namespace Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int32 _1=90, _2=45, _3=0;
            //Double _1=3.6,_2=75.09,_3=0.0;
            char _1='Z',_2='Q',_3='\0';
            Console.WriteLine(_1+" "+_2);

            // shorthand: _1=_1+_2;>> _1+=_2

            // swap by + -
            _1+=_2;//_1=_1+_2;
            _2=(char)(_1-_2);
            _1-=_2;//_1=_1-_2;

            /* // swap by * /
            _1*=_2;
            _2=_1/_2;
            _1/=_2; */

            /* //swap by third variable
            _3=_1;
            _1=_2;
            _2=_3; */

            Console.WriteLine("After swap: "+_1+" and "+_2);
        }
    }   
}
