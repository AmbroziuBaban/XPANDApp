using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IRobotRepository Robot { get; }
        ICaptainRepository Captain { get; }
        IDescriptionRepository Description { get; }
        IPlanetRepository Planet { get; }
        void Save();
    }
}
