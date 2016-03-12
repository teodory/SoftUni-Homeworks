using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CustomLINQExtensionMethods
{
    public static class Extensions
    {

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();

            foreach (T element in collection)
            {
                if (!predicate(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate) where TSelector : IComparable<TSelector>
        {

            if (!collection.Any())
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            var max = predicate((collection as List<TSource>)[0]);

            for (int i = 1; i < collection.Count(); i++)
            {
                var current = predicate((collection as List<TSource>)[i]);

                if (max.CompareTo(current) < 0)
                {
                    max = current;
                }
            }
            return max;
        }

    }
}
