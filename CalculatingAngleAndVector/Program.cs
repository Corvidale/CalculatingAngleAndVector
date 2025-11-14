using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAngleAndVector
{

    internal class Program
    {
        private Vector startPoint = new Vector(4,2);

        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        private void start()
        {
            Console.WriteLine(startPoint.getX());
            Console.ReadLine();
        }

        private class Vector
        {
            float x, y;
            public Vector(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public float getX()
            {
                return x;
            }
            public float getY()
            {
                return y;
            }
        }
    }
    
}
