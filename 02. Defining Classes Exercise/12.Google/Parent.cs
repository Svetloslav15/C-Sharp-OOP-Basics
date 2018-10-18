using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
    public class Parent
    {
        private string name;
        private string birthday;

        public Parent(string name, string date)
        {
            this.name = name;
            this.birthday = date;
        }
        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
    }
}