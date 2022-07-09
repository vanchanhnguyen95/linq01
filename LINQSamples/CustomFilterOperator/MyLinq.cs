using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFilterOperator
{
    public static class MyLinq
    {
        // 1. Read only
        // 2. Forward only
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source,Func<T, bool> predicate)
        {
            // Cach 1
            //var result = new List<T>();
            //foreach (var item in source)
            //{
            //    if(predicate(item))
            //    {
            //        result.Add(item);
            //    }    
            //}

            //return result;

            // Cach 2
            // dùng trong trường hợp trả về chỉ duyệt và đọc, tăng perfomance
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }
    }
}
