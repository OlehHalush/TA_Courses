﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1) Create abstract class Shape with field name and property Name. 
Add constructor with 1 parameter  and abstract methods Area() and Perimeter(), which can return area and perimeter of shape; 
Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for Square).   Add necessary constructors, properties to these classes, override methods from abstract class Shape. 
a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.  Write name, area and perimeter of all shapes. 
b) Find shape with the largest perimeter and print its name. 
3) Sort shapes by area and print obtained list (Remember about IComparable)
*/

namespace HW7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create and output 10 shapes
            List<Shape> listOfShapes = new List<Shape>();
            listOfShapes.Add(new Circle("Circle", 1));
            listOfShapes.Add(new Square("Square", 1, 1));
            listOfShapes.Add(new Circle("Circle2", 2));
            listOfShapes.Add(new Square("Square2", 2, 2));
            listOfShapes.Add(new Circle("Circle3", 3));
            listOfShapes.Add(new Square("Square3", 3, 3));
            listOfShapes.Add(new Circle("Circle4", 4));
            listOfShapes.Add(new Square("Square4", 4, 4));
            listOfShapes.Add(new Circle("Circle5", 5));
            listOfShapes.Add(new Square("Square5", 5, 5));
            Console.WriteLine("GET NAME, AREA AND PERIMETER OF ALL SHAPES:");
            Console.WriteLine("\tName\tArea\tPerimeter");
            foreach (Shape someShape in listOfShapes)
            {
                Console.WriteLine("\t" + someShape.Name + "\t" + someShape.GetArea() + "\t" + someShape.GetPerimeter());
            }

            // Find shape with the largest perimeter and print its name.
            Console.WriteLine("\nGET SHAPE WITH MAX PERIMETER");
            double maxPerim = 0;
            string name = string.Empty;
            foreach (Shape someShape in listOfShapes)
            {
                if (maxPerim <= someShape.GetPerimeter())
                {
                    maxPerim = someShape.GetPerimeter();
                    name = someShape.Name;
                }
            }

            Console.WriteLine("The max permimeter {0} is in a {1}.", maxPerim, name);

            // Sort shapes by area and print obtained list
            Console.WriteLine("\nGET SORTED LIST BY AREA");
            listOfShapes.Sort();
            Console.WriteLine("\tName\tArea");
            foreach (Shape someShape in listOfShapes)
            {
                Console.WriteLine("\t" + someShape.Name + "\t" + someShape.GetArea());
            }
        }
    }
}
