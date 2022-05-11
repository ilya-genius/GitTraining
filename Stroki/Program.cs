using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            List<int> mas = new List<int>();
            mas.AddRange(new int[] { 2,3,5});
            foreach (var el in mas)
            {
                Console.WriteLine(el);
            }
            Console.ReadKey();
        }
    }
}
