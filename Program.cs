using System;
using System.Collections;

namespace Nullable
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            int? b = 7;
            Double? c = null;
            Double? d = 4;
            bool? val = new bool?();
            DateTime? Start = DateTime.Today;
            DateTime? End = null;
            Console.WriteLine("showing values of nullables: {0}, {1}, {2}, {3}" ,a,b,c,d);
            Console.WriteLine("A Nullable Boolean Variable: {0}", val);
            Console.WriteLine(Start);
            Console.WriteLine("We don't know yet:", End);
            Console.Read();
        }
    }
}