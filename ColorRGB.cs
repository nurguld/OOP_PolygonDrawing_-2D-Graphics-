//**************************************************************************************************
//**************************************************************************************************
//***********              STUDENT NAME : NURGÜL DİNÇER                       **********************
//**********               STUDENT NUMBER : B231202067                        **********************
//**************************************************************************************************


using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP
{
    public class ColorRGB
    {
        // define properties
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public ColorRGB() // constructer with no parameter 
        {
            // set the colors value 0
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public ColorRGB(int red, int green, int blue) //constructer with parameter
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public ColorRGB(Random random) 
        { 
            // assign ransom value
            Red = random.Next(0, 256);
            Green = random.Next(0, 256);
            Blue = random.Next(0, 256);
        }

        public Color GetColor() => Color.FromArgb(Red, Green, Blue); //we create a object named color combined color value
    

    
    }
}
