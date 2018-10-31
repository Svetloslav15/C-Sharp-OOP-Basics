using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses.Models
{
    public class Mission
    {
        public string CodeName { get; set; }
        private string state;
        public Mission(string code, string state)
        {
            this.CodeName = code;
            this.State = state;
        }
        public string State
        {
            get => this.state;
            set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Invalid state!");
                }
                this.state = value;
            }
        }
        public void CompleteMission()
        {
            this.state = "Finished";
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.state}";
        }
    }
}
