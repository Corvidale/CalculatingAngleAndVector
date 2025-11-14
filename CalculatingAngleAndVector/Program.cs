using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAngleAndVector
{

    internal class Program
    {
        private Vector startPoint = new Vector(1,1);
        private Vector endPoint = new Vector(5,5);
        private float startVelocity = 2;
        private float globalGravity = 0.01f;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.start();
        }
        private void start()
        {
            Console.WriteLine(startPoint.GetX());
            Console.ReadLine();
        }
        private void CalculateInitialAngle(Vector startPos, Vector endPos, float gravity,float initialVelocity)
        {

        }
        private void VectorFromAngle(float angle, Vector startPos)
        {

        }

        private class Vector
        {
            float x, y;
            public Vector(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
            public float GetX()
            {
                return x;
            }
            public float GetY()
            {
                return y;
            }
        }
    }
    
}
