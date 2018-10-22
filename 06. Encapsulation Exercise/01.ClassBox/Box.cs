using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Box(decimal length, decimal width, decimal height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public decimal Volume()
        {
            return length * width * height;
        }

        public decimal LateralSurface()
        {
            return  2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public decimal Surface()
        {
            return 2 * (width * height + height * length + length * width);
        }
    }
}
