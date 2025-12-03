using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => length = value;
        }

        public double GetArea() => length * breadth;
        public string GetDetails() => $"Length: {length}, Breadth: {breadth}";
        public double GetPerimeter() => 2 * (length + breadth);

    }
}
