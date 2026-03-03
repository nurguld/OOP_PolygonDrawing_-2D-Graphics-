//**************************************************************************************************
//**************************************************************************************************
//***********              STUDENT NAME : NURGÜL DİNÇER                       **********************
//**********               STUDENT NUMBER : B231202067                        **********************
//**************************************************************************************************


using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Project_OOP

{

    public class Point2D

    {
        // define properties
        public double X { get; set; }
        public double Y { get; set; }
        public double r { get; set; }
        public double theta { get; set; }

        public Point2D(double x, double y) //constructer with parameter
        {
            this.X = x;
            this.Y = y;
            CalculatePolarCoordinates();
        }

        public Point2D() //constructer with no parameter
        {
            Random random = new Random();
            // assign random value x and y
            this.X = random.Next(0, 4);  
            this.Y = random.Next(0, 4);
            CalculatePolarCoordinates();
        }
        public string PrintCoordinates()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})");
            return $"({X}, {Y})";
        }



        public void CalculatePolarCoordinates()
        {
            this.r = Math.Sqrt(X * X + Y * Y);
            this.theta = Math.Atan2(Y, X) * 180 / Math.PI;
        }
        public void CalculateCartesianCoordinates()
        {
            this.X = r * Math.Cos(theta * Math.PI / 180);
            this.Y = r * Math.Sin(theta * Math.PI / 180);
        }

        public void printPolarCoordinates()
        {
            Console.WriteLine($" r : {r}   theta : {theta} ° ");
            Console.ReadLine();

        }
    }
}