using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.ExtensionMethods
{
    public static class StringExtensions
    {
        public static double ToDouble(this string data)
        {
            double result = double.Parse(data);
            return result;
        }
    }
}
