﻿using System;

namespace _0_is
{
    class Obj
    {
        public static bool IsOfTypeInt(object obj)
        {
            if (obj.GetType() == typeof(int))
                return(true);
            else
                return(false);
        }
    }
}
