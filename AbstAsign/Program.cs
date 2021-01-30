using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstAsign
{
    abstract class Quadrilateral
    {
        public int Length { get; set; }
        public abstract void Area();
    }
    class Square : Quadrilateral
    {
        public override void Area()
        {
            Console.WriteLine($"Area of the Square is {Length*Length}");
        }
        public void Perimeter()
        {
            Console.WriteLine($"perimeter of the Square is {(4*Length)}");
        }
    }
    class Rectangle : Quadrilateral
    {
        public int Breadth;

        public bool IsSquare()
        {
            if (Length == Breadth)
                return true;
            else
                return false;
        }
        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of the Rectangle is {Length*Breadth}");
        }
        public override void Area()
        {
            Console.WriteLine($"Area of the Rectangle is {2*(Length+Breadth)}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            Square S = new Square();
            S.Length = 4;
            R.Length = 5;
            R.Breadth = 6;
            S.Area();
            R.Area();
            S.Perimeter();
            R.Perimeter();
            Console.WriteLine(R.IsSquare());
            Console.ReadKey();
        }
    }
}
