using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_arr.Extensions;

namespace test_arr
{
    public static class Program
    {
        private const int NumberCount = 20;
        private const int NumberStart = 0;
        private const int NumberEnd = 99;
        private static readonly Random Random = new();
        static void Main(string[] args)
        {
            var array = Enumerable.Range(0, NumberCount).Select(_=>Random.Next(NumberStart,NumberEnd+1)).ToArray();
            array = array.OrderBy( x => x ).ToArray();

            array.Select((value, index) => $"{index}:{value}").ForEach(Console.WriteLine);
            //Console.WriteLine(string.Join(", ",array));
            Console.ReadKey();
        }

       
    }
}
