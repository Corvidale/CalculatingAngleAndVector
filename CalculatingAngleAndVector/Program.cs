using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAngleAndVector
{

    internal class Program
    {

        private string name = "test";
        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        private void start()
        {
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
