using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface ICaptainRepository : IRepositoryBase<Captain>
    {
        IEnumerable<Captain> GetAllCaptains();
        Captain GetCaptainById(Guid captainId);
        void CreateCaptain(Captain captain);
        void UpdateCaptain(Captain captain);
        void DeleteCaptain(Captain captain);
    }
}
