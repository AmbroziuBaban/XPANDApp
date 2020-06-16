using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DescriptionRepository : RepositoryBase<Description>, IDescriptionRepository
    {
        public DescriptionRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateDescription(Description description)
        {
            Create(description);
        }

        public void DeleteDescription(Description description)
        {
            Delete(description);
        }

        public void DeleteDescriptionById()
        {

        }

        public IEnumerable<Description> GetAllDescriptions()
        {
            return FindAll()
                 
                .ToList();
        }

        public Description GetDescriptionById(Guid descriptionId)
        {
            return FindByCondition(e => e.Id.Equals(descriptionId))
                .Include(c => c.Captain)
                .Include( d => d.DescriptionRobots)
                .ThenInclude(r => r.Robot)
                .FirstOrDefault();

        }

        public void UpdateDescription(Description description)
        {
            Update(description);
        }
    }
}
