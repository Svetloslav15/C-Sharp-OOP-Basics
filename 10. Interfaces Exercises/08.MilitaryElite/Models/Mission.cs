using MilitaryElite.Contracts;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public string CodeName { get; private set; }
        public State State { get; private set; }

        public void CompleteMission()
        {
            this.State = State.Finished;
        }

        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
    }
}
