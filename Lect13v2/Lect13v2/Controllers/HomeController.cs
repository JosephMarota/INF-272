using Lect13v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lect13v1.Controllers
{
    public class HomeController : Controller
    {
        public static List<Shape> shapes = new List<Shape>();
        public ActionResult Index2()
        {
            return View(shapes);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Rectangle()
        {
            return View();
        }
        public ActionResult Triangle()
        {
            return View();
        }

        public ActionResult Circle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Circle(string desc, string fill, string outline, double stroke, int xCoord, int yCoord, int radius)
        {
            Circle newC = new Circle()
            {
                Description = desc,
                Fill = fill,
                StrokeColour = outline,
                StrokeWidth = stroke,
                X = xCoord,
                Y = yCoord,
                Radius = Convert.ToInt32(radius),
            };
            shapes.Add(newC);
            return View("Display", newC);
        }
        [HttpPost]
        public ActionResult Rectangle(string desc, string fill, string outline, double stroke, int xCoord, int yCoord, int width, int height)
        {
            Rectangle newR = new Rectangle()
            {
                Description = desc,
                Fill = fill,
                StrokeColour = outline,
                StrokeWidth = stroke,
                X = xCoord,
                Y = yCoord,
                Width = width,
                Height = height
            };
            shapes.Add(newR);
            return View("Display", newR);
        }
        [HttpPost]
        public ActionResult Ellipse(string desc, string fill, string outline, double stroke, int xCoord, int yCoord, int XRadius, int YRadius)
        {
            Ellipse newE = new Ellipse()
            {
                Description = desc,
                Fill = fill,
                StrokeColour = outline,
                StrokeWidth = stroke,
                X = xCoord,
                Y = yCoord,
                XRadius = XRadius,
                YRadius = YRadius
            };
            shapes.Add(newE);
            return View("Display", newE);
        }
        [HttpPost]
        public ActionResult Triangle(string desc, string fill, string outline, double stroke, int xCoord1, int yCoord1, int xCoord2, int yCoord2, int xCoord3, int yCoord3)
        {
            Triangle newT = new Triangle()
            {
                Description = desc,
                Fill = fill,
                StrokeColour = outline,
                StrokeWidth = stroke,
                Points = new int[] { xCoord1, yCoord1, xCoord2, yCoord2, xCoord3, yCoord3 }
            };
            shapes.Add(newT);
            return View("Display", newT);
        }
        public ActionResult Ellipse()
        {
            return View();
        }

        public ActionResult Display(Shape shape)
        {
            return View(shape);
        }

        [HttpPost]
        public ActionResult Add(string desc, string fill, string outline, double stroke, int type, int xCoord, int yCoord, int? width, int? height, int? radius)
        {

            Shape newS = null;
            if (type == 1)
            {
                // Create new Rectangle instance and add to list

                Rectangle newR = (Rectangle)newS; //casting
                newR = new Rectangle(desc, fill, outline, stroke, xCoord, yCoord, Convert.ToInt32(width), Convert.ToInt32(height));


                shapes.Add(newR);
                

            }

            else if (type == 2)
            {
                Circle newC = new Circle()
                {
                    Description = desc,
                    Fill = fill,
                    StrokeColour = outline,
                    StrokeWidth = stroke,
                    X = xCoord,
                    Y = yCoord,
                    Radius = Convert.ToInt32(radius),
                };
                shapes.Add(newC);
                
            }

            return RedirectToAction("Index2");



        }
    }
}
