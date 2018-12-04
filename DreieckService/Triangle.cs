using System;
using System.Linq;

namespace DreieckService
{
    public class Triangle
    {
        double[] Sides;
        public Triangle(double[] _sides)
        {
            // Convert from nullable
            Sides = _sides;
            Array.Sort(Sides);
        }

        public string GetDescription()
        {
            // Check for invalid triangles
            if (Sides.Any(side => (side <= 0 ) || (Sides[2] >= (Sides[1] + Sides[0]))))
                return "an invalid triangle";

            // Check for equilateral triangle
            if ((Sides[0] == Sides[1]) && (Sides[1] == Sides[2]))
                return "a valid equilateral triangle";

            // Check for right triangle
            if((Math.Pow(Sides[2], 2) == (Math.Pow(Sides[1], 2) + Math.Pow(Sides[0], 2))))
            {
                return "a valid right triangle";
            }

            // Check for isosceles
            if ((Sides[0] == Sides[1]) || (Sides[1] == Sides[2]))
                return "a valid isosceles triangle";

            //NOTE: While technically you could check for a "right isosceles" triangle
            //  it does not make sense to do so, since you are guaranteed at least
            //  one irrational side.  It would be impossible for a user to input.

            return "a valid triangle";
        }
    }
}
