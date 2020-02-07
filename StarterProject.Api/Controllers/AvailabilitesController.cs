
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Availabilities;
using StarterProject.Api.Features.Availabilities.Dtos;

namespace StarterProject.Api.Controllers
{
    [Authorize]
    [ApiController]
    //Still need constructor
    
    public class AvailabilitiesController : ControllerBase
    {

        private readonly IAvailabilityRepository _availabilityRepository;

        public AvailabilitiesController(
            IAvailabilityRepository availabilityRepository)
        {
            _availabilityRepository = availabilityRepository;
        }
        
        [AllowAnonymous]
        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(AvailabilityGetDto),(int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] AvailabilityCreateDto availabilityCreateDto)
        {

            var availability = _availabilityRepository.CreateAvailability(availabilityCreateDto);     
            return Created("[controller]", availability);
        }


        [HttpPut("[controller]/{availabilityId:int}")]
        public IActionResult Put(int availabilityId, [FromBody] AvailabilityEditDto availabilityEditDto)
        {
            var availability = _availabilityRepository.EditAvailability(availabilityId, availabilityEditDto);
            return Ok(availability);
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<AvailabilityGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var availabilites = _availabilityRepository.GetAllAvailabilities();
            return Ok(availabilites);
        }

        [AllowAnonymous]
        [HttpGet("[controller]/{availabilityId:int}")]
        [ProducesResponseType(typeof(AvailabilityGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int availabilityId)
        {
            var availability = _availabilityRepository.GetAvailability(availabilityId);
            return Ok(availability);
        }
    }   

}