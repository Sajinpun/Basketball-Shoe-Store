using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bshoestore.Models
{
    public static class IdSetter
    {
        private static int seed = 1;

        
        public static int setId()
        {
            return seed;
        }

        public static void incrementId()
        {
            seed++;
        }

        public static void resetID()
        {
            seed = 1;
        }
    }
}