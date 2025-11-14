using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAngleAndVector
{

    internal class Program
    {
        private Vector startPoint = new Vector(1,1);        //testing values
        private Vector endPoint = new Vector(5,5);
        private float startVelocity = 2;
        private float globalGravity = 0.01f;

        static void Main(string[] args)     //legally obliged to have this
        {
            Program program = new Program();
            program.start();
        }
        private void start()
        {
            Console.WriteLine(CalculateInitialAngle(startPoint, endPoint, globalGravity, startVelocity));
            Console.ReadLine();     //testing

            
        }
        //finds the angle that it should aim at to hit the endpoint (parabole)
        private float CalculateInitialAngle(Vector startPos, Vector endPos, float gravity, float initialVelocity)
        {
            Vector u = new Vector(endPos.GetX() - startPos.GetX(), endPos.GetY() - startPos.GetY());


                //component in kenematic parabole calc
            float underRoot = (float)Math.Pow(initialVelocity, 4) - gravity * (gravity * (float)Math.Pow(u.GetX(), 2) + 2 * u.GetY() * (float)Math.Pow(initialVelocity, 2));

            if (underRoot < 0)  // checks if it is within range and for now it ouputs one if its not
            {
                return 1;
            }
            float squareRoot = (float)Math.Sqrt(underRoot);     // rest of the kenematic parabole calc
            float lowAngle = (float)Math.Atan2((float)Math.Pow(initialVelocity, 2) - squareRoot , gravity * u.GetX());

            return lowAngle;
        }
        private Vector VectorFromAngle(float angle,Vector startpos) 
        { 
        
        
            return new Vector(0, 0);
        }
        

        private class Vector    //vector class cuz it's more convienient and it looks cool
        {
            float x, y;
            public Vector(float x, float y) //constructor, makes it easier to create new vectors
            {
                this.x = x;
                this.y = y;
            }
            public float GetX()     //allows access to x value
            {
                return x;
            }
            public float GetY()     //allows access to y value
            {
                return y;
            }
        }
    }
    
}
