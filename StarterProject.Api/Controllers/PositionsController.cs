using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Common;
using StarterProject.Api.Dtos.Positions;
using StarterProject.Api.Features.Positions;
using StarterProject.Api.Features.Positions.Dtos;
using StarterProject.Api.Services;
using System.Collections.Generic;
using System.Net;

namespace StarterProject.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IPositionRepository _positionRepository;

        public PositionsController(
            IPositionRepository positionRepository)
        {
            _positionRepository = positionRepository;
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<PositionGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var positions = _positionRepository.GetAllPositions();
            return Ok(positions);
        }

        [HttpGet("[controller]/{positionsId:int}")]
        [ProducesResponseType(typeof(PositionGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int positionId)
        {
            var position = _positionRepository.GetPosition(positionId);
            return Ok(position);
        }

        [HttpPost("[controller]")]
        [ProducesResponseType(typeof(PositionGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] PositionCreateDto positionCreateDto)
        {
            var position = _positionRepository.CreatePosition(positionCreateDto);
            return Created("[controller]", position);
        }

        [HttpPut("[controller]/{positionId:int}")]
        [ProducesResponseType(typeof(PositionGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int positionId, [FromBody] PositionEditDto positionEditDto)
        {
            var position = _positionRepository.EditPosition(positionId, positionEditDto);
            return Ok(position);
        }

        [HttpDelete("[controller]/{positionId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int positionId)
        {
            _positionRepository.DeletePosition(positionId);
            return Ok();
        }
    }
}