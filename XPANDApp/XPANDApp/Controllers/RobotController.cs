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
    [Route("api/robot")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public RobotController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllRobots()
        {
            try
            {
                var robots = _repository.Robot.GetAllRobots();
                var robotss = _repository.Robot.FindAll();

                return Ok(robotss);
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "RobotById")]
        public IActionResult GetRobot(Guid id)
        {
            try
            {
                var robot = _repository.Robot.GetRobotById(id);

                if(robot == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(robot);
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult AddRobot([FromBody] RobotForCreationDto robot)
        {
            try
            {
                if(robot == null)
                {
                    return BadRequest("Robot object is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }
               
                var robotEntity = _mapper.Map<Robot>(robot);

                _repository.Robot.CreateRobot(robotEntity);
                _repository.Save();

                return CreatedAtRoute("RobotById", new { id = robotEntity.Id }, robotEntity);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRobot(Guid id,[FromBody] Robot robot)
        {
            try
            {
                if (robot == null)
                {
                    return BadRequest("Robot oject is null");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid object model");
                }

                var robotEntity = _repository.Robot.GetRobotById(id);

                if(robotEntity == null)
                {
                    return NotFound();
                }

                
                _repository.Robot.UpdateRobot(robot);
                _repository.Save();

                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}