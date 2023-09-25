using System;

namespace Methods
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        // Constructor
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


        // Method overloading
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            Move(newLocation.X, newLocation.Y);
        }
    }
}
