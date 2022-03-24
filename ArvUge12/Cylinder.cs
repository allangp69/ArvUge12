using System;
using System.Collections.Generic;
using System.Text;

namespace ArvUge12
{
    class Cylinder
        : Circle
    {
        private double height;

        public Cylinder(double radius, double height)
            : base(radius)
        {
            this.height = height;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }
        public double GetHeight()
        {
            return this.height;
        }

        public double CalcVolume()
        {            
            return CalcArea() * height;
        }

        public override string ToString()
        {
            return $"This is a cylinder with the radius: {radius} and height: {height}";
        }
    }
}
