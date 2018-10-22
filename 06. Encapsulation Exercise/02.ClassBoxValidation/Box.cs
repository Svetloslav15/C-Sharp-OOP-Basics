using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Box
    {
        private decimal length;
        private decimal width;

        public decimal Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public decimal Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        private decimal height;

        public decimal Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Box(decimal length, decimal width, decimal height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public decimal Volume()
        {
            return length * width * height;
        }

        public decimal LateralSurface()
        {
            return 2 * (this.length * this.height) + 2 * (this.width * this.height);
        }

        public decimal Surface()
        {
            return 2 * (width * height + height * length + length * width);
        }
    }
}