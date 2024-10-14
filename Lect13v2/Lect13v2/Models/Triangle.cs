using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Lect13v1.Models
{
    public class Triangle:Shape
    {
        public int[] Points { get; set; }
        public Triangle()
        {

        }
        public Triangle(string desc, string fill, string sColour, double sWidth, int[] points) : base(desc, fill, sColour, sWidth)
        {
            Points = points;
        }

        public override string getSVG()
        {
            string result = "<svg style='border: 1pt dashed #333' height='" + base.SvgHeight + "' width='" + base.SvgWidth + "'>";
            result += $"<polygon points=\"{Points[0]},{Points[1]} {Points[2]},{Points[3]} {Points[4]},{Points[5]}\" style=\"fill:{base.Fill};stroke:{base.StrokeColour};stroke-width:{base.StrokeWidth}\" />";
            result += "</ svg > ";
            return result;
        }

        public override double getArea()
        {

            double area = 0;
            area += Points[2] * (Points[5] - Points[1]);
            area += Points[4] * (Points[1] - Points[3]);
            area = Math.Abs(area);
            area *= 0.5;
            return area;
        }
    }
}