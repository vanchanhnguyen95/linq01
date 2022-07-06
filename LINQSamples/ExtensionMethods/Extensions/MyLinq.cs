using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.ExtensionMethods
{
    public static  class MyLinq
    {
        public static int Count<T>(this IEnumerable<T> sequense)
        {
            int count = 0;
            foreach(var item in sequense)
            {
                count++;
            }
            return count;
        }    
    }
}
