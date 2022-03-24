using System;
using System.Collections.Generic;
using System.Text;

namespace ArvUge12
{
    class Circle
    {
        protected double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return this.radius;
        }

        public double CalcArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public override string ToString()
        {
            return $"This is a circle with radius: {radius}";
        }
    }
}
