using System;
using System.Collections.Generic;
using System.Linq;

namespace null_coalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            string color =null;
            Console.WriteLine(color ?? "No Color");

            string a = "Type";
            string b = "Not null";

            Console.WriteLine(b ?? a);

            Console.WriteLine(Coalescing.Nullable());

            Console.ReadLine();
        }
    }

    public class Coalescing
    {
        public static string Nullable()
        {
            string a = "Type";
            string b = null;
            return b ?? a;
        }
    }
}
