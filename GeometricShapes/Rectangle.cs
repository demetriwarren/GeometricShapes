using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    internal class Rectangle : Quad
    { 
        public new int Area()   //new indicates to Pull from Rectangle and not the Quad class
        {
            return Side1 * Side2;
        }
        public Rectangle(int side1, int side2) : base(side1, side2, side1, side2) //base parameters come from the constructer being inherited from(in this case its Quad)
        {
            Side1 = side1;
            Side2 = side2;
        }
    }
}
