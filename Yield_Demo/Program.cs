using System;
using System.Collections.Generic;

namespace Yield_Demo
{
    class Program
    {
        static void Main()
        {
            IList<int> values = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // output 2,4,6,8,10
            Console.WriteLine(string.Join(",", GetEvenNumberByTemp(values)));

            // output 2,4,6,8,10
            Console.WriteLine(string.Join(",", GetEvenNumberByYield(values)));

            Console.Read();
        }

        private static List<int> GetEvenNumberByTemp(IEnumerable<int> values)
        {
            var temps = new List<int>();

            foreach (var value in values)
            {
                if (value % 2 == 0)
                {
                    temps.Add(value);
                }
            }

            return temps;
        }

        private static IEnumerable<int> GetEvenNumberByYield(IEnumerable<int> values)
        {
            foreach (var value in values)
            {
                if (value % 2 == 0)
                {
                    yield return value;
                }
            }

            yield return 100;
        }
    }
}
