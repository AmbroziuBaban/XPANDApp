using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class CaptainRepository : RepositoryBase<Captain>, ICaptainRepository
    {
        public CaptainRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        { }

        public void CreateCaptain(Captain captain)
        {
            Create(captain);
        }

        public void DeleteCaptain(Captain captain)
        {
            Delete(captain);
        }

        public IEnumerable<Captain> GetAllCaptains()
        {
            return FindAll().OrderBy(e => e.Name)
                .ToList();
        }

        public Captain GetCaptainById(Guid captainId)
        {
            return FindByCondition(e => e.Id.Equals(captainId))
                .FirstOrDefault();
        }

        public void UpdateCaptain(Captain captain)
        {
            Update(captain);
        }
    }
}
