using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XPANDApp.Controllers
{
    [Route("api/planet")]
    [ApiController]
    public class PlanetController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public PlanetController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllPlanets()
        {
            try
            {
                var planets = _repository.Planet.GetAllPlanets();
                return Ok(planets);
            }
            catch(Exception ex)
            {
               return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}",Name ="PlanetById")]
        public IActionResult GetPlanetById(Guid id)
        {
            try
            {
                var planet = _repository.Planet.GetPlanetById(id);

                if(planet == null)
                {
                   return NotFound();
                }

                return Ok(planet);
               
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult AddPlanet([FromBody] PlanetForCreationDto planet)
        {
            try
            {
                if(planet == null)
                {
                    return BadRequest("Planet object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Object is not valid");
                }

                var planetEntity = _mapper.Map<Planet>(planet);

                _repository.Planet.CreatePlanet(planetEntity);
                _repository.Save();

                return CreatedAtRoute("PlanetById", new { id = planetEntity.ID }, planetEntity);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}