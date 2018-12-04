using System;

namespace ProjectDreieck
{
    public class Triangle : IShape
    {
        private int?[] Sides { get; set; }
        private readonly string Name = "Triangle";

        public void SetSides(int?[] _sides)
        {
            Sides = _sides;
            Array.Sort(Sides);
        }

        public int?[] GetSides()
        {
            return new int?[] { 1,2,3 };
        }

        public string GetName()
        {
            return Name;
        }
    }
}
