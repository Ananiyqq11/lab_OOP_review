using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labconsole1_OOP_review_
{
   
 abstract class Shape
    {
        public abstract double CalcArea();
        public abstract double CalcPerimeter();
    }
   class square
    {    
        public double length  { get; set; }
        public double CalcArea() { return length *length; }
        public double CalcPerimeter() { return 4.0 *length; }
   
    } 
    class circle
    {
       readonly private double pie=3.1415;
        private double radius;
        public double radius1
        {
            set { radius = value; }
            get { return radius; }
        }
        public double pie1
        {
            get { return pie; }
        }
        public double CalcArea() { return radius * pie * radius; }
        public double CalcPerimeter() { return 2.0 * pie * radius; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            square square = new square();

            Console.WriteLine("Enter Radius value for circle");
            circle.radius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value of Radius :- "+circle.radius1);
            Console.WriteLine("Value of Area :- "+circle.CalcArea());
            Console.WriteLine("Value of Perimeter :- " + circle.CalcPerimeter());

            Console.WriteLine("**************************************************");

            Console.WriteLine("Enter length value for square");
            square.length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Value of Radius :- " + square.length);
            Console.WriteLine("Value of Area :- " + square.CalcArea());
            Console.WriteLine("Value of Perimeter :- " + square.CalcPerimeter());

        }
    }
}
