using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lect13v1.Models
{
    public class Circle: Shape
    {
        

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle()
        {
        }

        public Circle(string desc, string fill, string sColour, double sWidth,int x, int y, int radius): base (desc, fill, sColour, sWidth)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public override string getSVG()
        {
            return ("<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'><circle cx='" + X + "' cy='" + Y + "' r='" + Radius + "' style='fill:" + base.Fill + ";stroke:" + base.StrokeColour + ";stroke‐width:" + base.StrokeWidth + "'/></svg>");
        }

        public override double getArea()
        {
            double area = 0;
            area = Math.PI * (Math.Pow(Radius, 2));
            return Math.Round(area, 2);
        }


    }
}