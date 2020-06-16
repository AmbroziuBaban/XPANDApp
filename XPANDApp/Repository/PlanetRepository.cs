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
    public class PlanetRepository : RepositoryBase<Planet>, IPlanetRepository
    {
        public PlanetRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<Planet> GetAllPlanets()
        {
            return FindAll().OrderBy(p => p.Name);
        }

        public Planet GetPlanetById(Guid id)
        {
            return FindByCondition(p => p.ID.Equals(id))
                .Include(d => d.Description)
                .FirstOrDefault();
        }

        public void CreatePlanet(Planet planet)
        {
            Create(planet);
        }

        public void UpdatePlanet(Planet planet)
        {
            Update(planet);
        }

        public void DeletePlanet(Planet planet)
        {
            Delete(planet);
        }
    }
}
