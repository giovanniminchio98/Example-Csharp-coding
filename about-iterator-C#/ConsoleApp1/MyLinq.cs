using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOwnLink
{
    internal static class MyLinq
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> coll, Func<T, bool> predicate)
        {
            foreach(T elem in coll)
            {
                if(predicate(elem) == true)
                {
                    yield return elem;
                }
            }
        }// where

        public static IEnumerable<R> Select<T,R>(this IEnumerable<T> coll, Func<T,R> map)
        {
            foreach (T elem in coll)
                yield return map(elem);
        }
    }
}
