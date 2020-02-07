using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarterProject.Api.Common;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Schedules;
using StarterProject.Api.Features.Schedules.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StarterProject.Api.Controllers
{
    [Authorize]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        // private readonly IScheduleService _scheduleService;
        private readonly IScheduleRepository _scheduleRepository;

        //private readonly DataContext _context;

        //public SchedulesController(DataContext context)
        //{
        //    _context = context;
        //}

        public SchedulesController(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        [AllowAnonymous]
       // [Authorize(Roles = Constants.Users.Roles.Admin)]
        [HttpPost("[controller]")]
        //[ProducesResponseType(typeof(ScheduleGetDto), (int)HttpStatusCode.Created)]
        public IActionResult Post([FromBody] ScheduleCreateDto scheduleCreateDto)
        {
            var stringUserId = User.FindFirst(ClaimTypes.Name)?.Value;
            var userId = int.Parse(stringUserId);

            scheduleCreateDto.UserId = userId;

            var schedule = _scheduleRepository.CreateSchedule(scheduleCreateDto);
            return Created("[controller]", schedule);
        }

        //[Authorize(Roles = Constants.Users.Roles.Admin)]
        [HttpPut("[controller]/{scheduleId:int}")]
       //[ProducesResponseType(typeof(ScheduleGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Put(int scheduleId, [FromBody] ScheduleEditDto scheduleEditDto)
        {
            var schedule = _scheduleRepository.EditSchedule(scheduleId, scheduleEditDto);
            return Ok(schedule);
        }

        [HttpGet("[controller]")]
        [ProducesResponseType(typeof(List<ScheduleGetDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            var schedules = _scheduleRepository.GetAllSchedules();
            return Ok(schedules);
        }


        [HttpGet("[controller]/{scheduleId:int}")]
        [ProducesResponseType(typeof(ScheduleGetDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int scheduleId)
        {
            var schedule = _scheduleRepository.GetSchedule(scheduleId);
            return Ok(schedule);
        }

        //[Authorize(Roles = Constants.Users.Roles.Admin)]
        [HttpDelete("[controller]/{scheduleId:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult Delete(int scheduleId)
        {
            _scheduleRepository.DeleteSchedule(scheduleId);
            return Ok();
        }

    }


}


//{
//    //public class ScheduleCreateDto
//    //{

//    //}

//    //public class ScheduleGetDto
//    //{
//    //    public int Id { get; set; }
//    //    public int UserId { get; set; }
//    //}

//    [Authorize]
//    [ApiController]
//    public class SchedulesController : ControllerBase
//    {
//        private readonly DataContext _context;

//        public SchedulesController(DataContext context)
//        {
//            _context = context;
//        }

//        [HttpPost("[controller]")]
//        [ProducesResponseType(typeof(ScheduleGetDto), (int)HttpStatusCode.Created)]
//        public IActionResult Post([FromBody] ScheduleCreateDto scheduleCreateDto)
//        {
//            var stringUserId = User.FindFirst(ClaimTypes.Name)?.Value;
//            var userId = int.Parse(stringUserId);

//            var schedule = new Schedule();
//            schedule.UserId = userId;

//            _context.Schedules.Add(schedule);
//            _context.SaveChanges();

//            var scheduleToReturn = new ScheduleGetDto();
//            scheduleToReturn.Id = schedule.Id;
//            scheduleToReturn.UserId = schedule.UserId;

//            return Ok(scheduleToReturn);
//        }

//    }
//}

