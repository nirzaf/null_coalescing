using System;
using System.Collections.Generic;
using System.Linq;

namespace null_coalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            Coalescing cl = new Coalescing();
            cl.Nullable();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }

    public class Coalescing
    {
        private int? x = null;
        private int y = 9;
        public Coalescing()
        {

        }
        double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
        {
            return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;
        }
        public void Nullable()
        {
            var sum = SumNumbers(null, 0);
            Console.WriteLine(sum);  // output: NaN
        }
    }
}
