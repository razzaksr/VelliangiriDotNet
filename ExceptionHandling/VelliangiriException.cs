using System;

namespace ExceptionHandling
{
    class VelliangiriException:Exception
    {
        public VelliangiriException():base("AuthenticationFailedException"){}
    }
}