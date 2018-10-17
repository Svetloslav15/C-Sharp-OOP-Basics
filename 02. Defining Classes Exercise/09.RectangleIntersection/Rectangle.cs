using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Rectangle
    {
        public string id { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double horizontal { get; set; }
        public double vertical { get; set; }

        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.horizontal = horizontal;
            this.vertical = vertical;
        }

        public string Intersect(Rectangle rect)
        {
            if (this.horizontal + this.width < rect.horizontal
            || rect.horizontal + rect.width < this.horizontal
            || this.vertical + this.height < rect.vertical
            || rect.vertical + rect.height < this.vertical)
            {
                return "false";
            }
            return "true";
        }
    }
}
