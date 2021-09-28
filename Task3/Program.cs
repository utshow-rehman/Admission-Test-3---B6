using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = GetLines();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static string[] GetLines()
        {
            string[] lines = new string[] { };
            string path=@"\aspnetb6-test3-main\AdmissionTest\Tasks\Task3\DemoText.txt";
          if(File.Exists(path))
            {
              lines = File.ReadAllLines(path);
                return lines;
            }
          else
          {
              Console.WriteLine("NOt Found");
          }

          return lines;

        }
    }
}
