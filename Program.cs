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

            Coalescing cl = new Coalescing();
            string a = "Type";
            string b = "Not null";

            Console.WriteLine(b ?? a);

            Console.WriteLine(cl.Nullable());

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

        public string Nullable()
        {
            string a = "Type";
            string b = null;

            return b ?? a;
        }
    }
}
