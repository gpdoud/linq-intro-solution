using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqIntroProject {
    class Program {
        static void Main(string[] args) {
            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                orderby num descending
                select num;

            var sumOfNumber = numbers
                            .Where(num => (num % 2) == 0)
                            .OrderByDescending(n => n)
                            .Sum(n => n * n);

            // 3. Query execution.
            foreach (int num in numQuery) {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine();
            //foreach (int num in numQuery2) {
            //    Console.Write("{0,1} ", num);
            //}
            Console.Write(sumOfNumber);
            Console.ReadKey();
        }
    }
}
