using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace XPANDApp.Controllers
{
    [Route("api/description")]
    [ApiController]
    public class DescriptionController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        private readonly RepositoryContext _context;

        public DescriptionController(IRepositoryWrapper repository, IMapper mapper, RepositoryContext context)
        {
            _repository = repository;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var descriptions = _repository.Description.GetAllDescriptions();

                return Ok(descriptions);
            }
            catch (Exception ex)
            {
                //
                return StatusCode(500, "Internal service error");
            }
        }

        [HttpGet("{id}", Name = "DescriptionById")]
        public IActionResult GetById(Guid id)
        {

            try
            {
                //var descriptions = _context.Descriptions
                //    .Include(dr => dr.DescriptionRobots)
                //    .ThenInclude(dr => dr.Robot)
                //    ;


                var descriptions = _repository.Description.GetDescriptionById(id);


                return Ok(descriptions);
            }
            catch (Exception ex)
            {
                //
                return StatusCode(500, "Internal service error");
            }
        }

        [HttpPost]
        public IActionResult AddDescription([FromBody]DescriptionForCreactionDto description)
        {
            try
            {
                if (description == null)
                {
                    return BadRequest("Description object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid object model");
                }

                var entityDescription = _mapper.Map<Description>(description);

                _repository.Description.CreateDescription(entityDescription);
                _repository.Save();


                // TODO : find why the robots arent retrived
                return CreatedAtRoute("DescriptionById", new { id = entityDescription.Id }, entityDescription);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDescription(Guid id, [FromBody] Description description)
        {
            try
            {
                if (description == null)
                {
                    return BadRequest("Robot oject is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid object model");
                }

                var robotEntity = _repository.Robot.GetRobotById(id);

                if (robotEntity == null)
                {
                    return NotFound();
                }

                _repository.Description.UpdateDescription(description);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDescription(Guid id)
        {
            try
            {
                var description = _repository.Description.GetDescriptionById(id);

                if (description == null)
                {
                    NotFound();
                }

                _repository.Description.DeleteDescription(description);
                _repository.Save();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }

        }
    }
}