using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Smartphone :IPhonable, IBrowserable
    {
        public void Brows(string url)
        {
            CheckUrl(url);
            Console.WriteLine($"Browsing: {url}!");
        }

        private void CheckUrl(string url)
        {
            if (url.Any(x => x >= '0' && x <= '9'))
            {
                throw new ArgumentException("Invalid URL!");
            }
        }

        public void Calling(string number)
        {
            CheckNumber(number);
            Console.WriteLine($"Calling... {number}");
        }

        private void CheckNumber(string number)
        {
            if (number.Any(x => x < '0' || x > '9'))
            {
                throw new ArgumentException("Invalid number!");
            }
        }
    }
}
