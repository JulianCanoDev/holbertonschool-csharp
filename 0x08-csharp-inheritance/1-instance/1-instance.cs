using System;

namespace _1_instance
{
    class Obj
    {
        public static bool IsInstanceOfArray(object obj)
        {
            if (obj is Array)
                return(true);
            else
                return(false);
        }
    }
}
