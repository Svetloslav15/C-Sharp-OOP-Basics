using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracts
{
    public interface IEngineer : IPrivate, ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; set; }
    }
}
