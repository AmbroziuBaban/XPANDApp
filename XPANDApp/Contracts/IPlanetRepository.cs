using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IPlanetRepository : IRepositoryBase<Planet>
    {
        public IEnumerable<Planet> GetAllPlanets();
        public Planet GetPlanetById(Guid id);
        public void CreatePlanet(Planet planet);
        public void UpdatePlanet(Planet planet);
        public void DeletePlanet(Planet planet);
    }
}
