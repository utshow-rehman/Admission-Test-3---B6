using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var item1 = new ProductFactory<ProductOne>().Create();
            Console.WriteLine(item1.Name);

            var item2 = new ProductFactory<ProductTwo>().Create();
            Console.WriteLine(item2.Name);
        }
    }
}
