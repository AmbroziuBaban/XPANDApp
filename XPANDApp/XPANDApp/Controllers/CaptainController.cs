using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace XPANDApp.Controllers
{
    [Route("api/captain")]
    [ApiController]
    public class CaptainController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public CaptainController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAlCaptains()
        {
            try
            {
                var captains = _repository.Captain.GetAllCaptains();

                return Ok(captains);
            }
            catch(Exception ex)
            {
                //
                return StatusCode(500, "Internal service error");
            }
        }
    }
}