using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_exercises
{
    internal class Triangle : Shape
    {
        private double baseh, height;

        public Triangle(double baseh, double height)
        {
            this.Baseh = baseh;
            this.Height = height;
        }

        public double Baseh { get => baseh; set => baseh = value; }
        public double Height { get => height; set => height = value; }

        public override double Area()
        {
            return 0.5 * baseh * height;
        }
    }
}
