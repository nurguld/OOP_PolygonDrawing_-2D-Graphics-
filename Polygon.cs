//**************************************************************************************************
//**************************************************************************************************
//***********              STUDENT NAME : NURGÜL DİNÇER                       **********************
//**********               STUDENT NUMBER : B231202067                        **********************
//**************************************************************************************************


using Project_OOP;

using System;
public class Polygon

{
    //define properties
    public Point2D Center { get; set; }
    public double Length { get; set; }
    public ColorRGB Color { get; set; }
    public int NumberOfEdges { get; set; }

    // array to store vertices
    public Point2D[] Vertices;

    public Polygon() //constructer with no parameter
    {
        Random rand = new Random();
        Center = new Point2D(0, 0);
        Length = 4;
        Color = new ColorRGB(rand);
        NumberOfEdges = 5;
        CalculateEdgeCoordinates();
    }

    public Polygon(Point2D center, double length, ColorRGB color, int edges) //constructer with parameter
    {
        Center = center;
        Length = length;
        Color = color;
        NumberOfEdges = edges;
        CalculateEdgeCoordinates();
    }

  
    public void CalculateEdgeCoordinates()
    {
        if (NumberOfEdges < 3)  // set the number of edges min 3
        {
            NumberOfEdges = 3; 
        }

        Vertices = new Point2D[NumberOfEdges]; //create array with size of number of edge
        double angleIncrement = 2 * Math.PI / NumberOfEdges;

       
        double startAngle = -Math.PI / 2;

        for (int i = 0; i < NumberOfEdges; i++)
        {
            double x = Center.X + Length * Math.Cos(startAngle + i * angleIncrement);
            double y = Center.Y + Length * Math.Sin(startAngle + i * angleIncrement);
            Vertices[i] = new Point2D(x, y);
        }
    }

    // Method to rotate the polygon
    public void RotatePolygon(double angle, bool isCounterClockwise)
    {
        if (isCounterClockwise) angle = -angle; //set the angle according to direction

        // Convert angle to radians
        double angleRad = angle * Math.PI / 180;

        for (int i = 0; i < NumberOfEdges; i++)
        {
            
            double translatedX = Vertices[i].X - Center.X;
            double translatedY = Vertices[i].Y - Center.Y;

            
            double rotatedX = translatedX * Math.Cos(angleRad) - translatedY * Math.Sin(angleRad);
            double rotatedY = translatedX * Math.Sin(angleRad) + translatedY * Math.Cos(angleRad);

            
            Vertices[i].X = rotatedX + Center.X; 
            Vertices[i].Y = rotatedY + Center.Y;


            Vertices[i].CalculatePolarCoordinates();
        }
    }
}