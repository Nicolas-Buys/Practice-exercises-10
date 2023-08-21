using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_exercises
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return Math.PI * radius;
        }
    }
}
