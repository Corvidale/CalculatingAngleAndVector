using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAngleAndVector
{

    internal class Program
    {
        private Vector startPoint = new Vector(1,1);        //example values
        private Vector endPoint = new Vector(5,5);
        private float startVelocity = 2;
        private float globalGravity = 0.01f;

        static void Main(string[] args)     //legally obliged to have this
        {
            Program program = new Program();
            program.Start();
        }
        private void Start()
        {                           //example
            Console.WriteLine(VectorFromAngle(CalculateInitialAngle(startPoint, endPoint, globalGravity, startVelocity, true), startPoint, startVelocity).GetX());
            Console.WriteLine(VectorFromAngle(CalculateInitialAngle(startPoint, endPoint, globalGravity, startVelocity, true), startPoint, startVelocity).GetY());
            Console.ReadLine();     
        }
        //finds the angle that it should aim at to hit the endpoint (parabole)
        private float CalculateInitialAngle(Vector startPos, Vector endPos, float gravity, float initialVelocity, bool isLowAngle)
        {
            Vector u = new Vector(endPos.GetX() - startPos.GetX(), endPos.GetY() - startPos.GetY());


                //component in kenematic parabole calc
            float underRoot = (float)Math.Pow(initialVelocity, 4) - gravity * (gravity * (float)Math.Pow(u.GetX(), 2) + 2 * u.GetY() * (float)Math.Pow(initialVelocity, 2));

            if (underRoot < 0)  // checks if it is within range and for now it ouputs one if its not
            {
                Console.WriteLine("Outside of range ");
                return 1; //Insert other thing if it is outside targetting range
            }
            float squareRoot = (float)Math.Sqrt(underRoot);     // rest of the kenematic parabole calc
            

            if (!isLowAngle)   //returns the high angle if specified
            {
                float highAngle = (float)Math.Atan2((float)Math.Pow(initialVelocity, 2) + squareRoot, gravity * u.GetX());
                return highAngle;   //output in radiance
            } 
            else     //returns the low angle if nothing is specified
            {
                float lowAngle = (float)Math.Atan2((float)Math.Pow(initialVelocity, 2) - squareRoot, gravity * u.GetX());
                return lowAngle;    //output in radiance
            }
        }
        private Vector VectorFromAngle(float angle,Vector startpos,float initialVelocity) 
        {
            Vector launchVector = new Vector(
                initialVelocity * (float)Math.Cos(angle), //x
                initialVelocity * (float)Math.Sin(angle)); //y
            
            return launchVector;
        }
        private class Vector    //vector class cuz it's more convienient and it looks cool
        {
            float x, y;
            public Vector(float x, float y) //constructor, makes it easier to create new vectors
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
        }   // removed the SetX & SetY function because i didn't need it for this project
    }
}
