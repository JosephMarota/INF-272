using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Lect13v1.Models
{
    public class Ellipse : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int XRadius { get; set;}
        public int YRadius { get; set;}
        public Ellipse()
        {
        }

        public Ellipse(string desc, string fill, string sColour, double sWidth, int x, int y, int xRadius, int yRadius) : base(desc, fill, sColour, sWidth)
        {
            X = x;
            Y = y;
            XRadius = xRadius;
            YRadius = yRadius;
        }

        public override double getArea()
        {
            return Math.PI * XRadius * YRadius;
        }

        public override string getSVG()
        {
            string result = "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'>";
            result += $"<ellipse rx=\"{XRadius}\" ry=\"{YRadius}\" cx=\"{X}\" cy=\"{Y}\"\r\n  style=\"fill:{base.Fill};stroke:{base.StrokeColour};stroke-width:{base.StrokeWidth}\" />";
            result += "</ svg > ";
            return result;
        }
    }
}