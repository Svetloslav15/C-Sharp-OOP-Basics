using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public bool Contains(Point outerPoint)
        {
            if (outerPoint.X >= TopLeft.X && outerPoint.X <= BottomRight.X &&
                outerPoint.Y >= TopLeft.Y && outerPoint.Y <= BottomRight.Y)
            {
                return true;
            }
            return false;
        }
    }
}