using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IDescriptionRepository : IRepositoryBase<Description>
    {
        IEnumerable<Description> GetAllDescriptions();
        Description GetDescriptionById(Guid descriptionId);
        void CreateDescription(Description description);
        void UpdateDescription(Description description);
        void DeleteDescription(Description description);
    }
}
