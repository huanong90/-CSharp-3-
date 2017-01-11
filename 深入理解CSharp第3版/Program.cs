using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreLinq;

namespace 深入理解CSharp第3版
{
    public class Program
    {
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }

        static void Main(string[] args)
        {
            
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            List<double> doubles = integers.ConvertAll(TakeSquareRoot);

            doubles.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public string Province { get; set; }
    }
}
