using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_exercises
{
    internal class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public override double Area()
        {
            return width * height;
        }
    }
}
