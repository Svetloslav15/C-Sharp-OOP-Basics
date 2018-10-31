using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class SpecialisedSoldier : Private
    {
        private string corp;

        public string Corp
        {
            get => this.corp;
            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException();
                }
                this.corp = value;
            }
        }

        public SpecialisedSoldier(string id, string firstname, string lastname, decimal salary, string corp)
            : base(id, firstname, lastname, salary)
        {
            Corp = corp;
        }
    }
}
