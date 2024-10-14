using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lect13v1.Models
{
    public class Rectangle: Shape
    {
        private int mX;     

        private int mY;
        private int mWidth;
        private int mHeight;

        public int Height { get => mHeight; set => mHeight = value; }
        public int X { get => mX; set => mX = value; }
        public int Y { get => mY; set => mY = value; }
        public int Width { get => mWidth; set => mWidth = value; }

        public Rectangle()
        {

        }

        public Rectangle(string desc, string fill, string sColour, double sWidth,int height, int x, int y, int width): base(desc, fill, sColour, sWidth)
            
        {
            Height = height;
            X = x;
            Y = y;
            Width = width;
        }

        public override double getArea()
        {
            double area = 0;
            area = mWidth * mHeight;
            return area;
        }

        public override string getSVG()
        {
            return "<svg style = 'border: 1pt dashed #333' height = '" + base.SvgHeight + "' width = '" + base.SvgWidth + "'><rect x='" + mX + "' y='" + mY + "' width='" + mWidth + "' height='" + mHeight + "' style = 'fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke‐width:" + base.StrokeWidth + "'/></svg>";
        }
    }
}