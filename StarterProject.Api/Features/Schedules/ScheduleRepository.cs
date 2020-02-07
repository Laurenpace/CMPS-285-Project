using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Schedules.Dtos;
using StarterProject.Api.Features.Users.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StarterProject.Api.Features.Schedules
{
    public interface IScheduleRepository
    {
        ScheduleGetDto GetSchedule(int scheduleId);
        List<ScheduleGetDto> GetAllSchedules();
        ScheduleGetDto CreateSchedule(ScheduleCreateDto scheduleCreateDto);
        ScheduleGetDto EditSchedule(int scheduleId, ScheduleEditDto scheduleUpdateDto);
        void DeleteSchedule(int scheduleId);
    }

    public class ScheduleRepository : IScheduleRepository
    {
        private readonly DataContext _context;
        
        public ScheduleRepository(DataContext context)
        {
            _context = context;
        }

        public ScheduleGetDto GetSchedule(int ScheduleId)
        {
            return _context
                .Set<Schedule>()
                .Select(x => new ScheduleGetDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    AvailabilityId = x.AvailabilityId,
                    PositionId = x.PositionId
                })
                .FirstOrDefault(x => x.Id == ScheduleId);
        }

        public List<ScheduleGetDto> GetAllSchedules()
        {
            return _context
                .Set<Schedule>()
                .Select(x => new ScheduleGetDto
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    AvailabilityId = x.AvailabilityId,
                    PositionId = x.PositionId
                })
                .ToList();
        }

        public ScheduleGetDto CreateSchedule(ScheduleCreateDto scheduleCreateDto)
        {
            var schedule = new Schedule
            {
                UserId = scheduleCreateDto.UserId,
                AvailabilityId = scheduleCreateDto.AvailabilityId,
                PositionId = scheduleCreateDto.PositionId
            };

            _context.Set<Schedule>().Add(schedule);
            _context.SaveChanges();

            var scheduleGetDto = new ScheduleGetDto
            {
                Id = schedule.Id,
                UserId = schedule.UserId,
                AvailabilityId = schedule.AvailabilityId,
                PositionId = schedule.PositionId
            };

            return scheduleGetDto;
        }

        public ScheduleGetDto EditSchedule(int scheduleId, ScheduleEditDto scheduleEditDto)
        {
            var schedule = _context.Set<Schedule>().Find(scheduleId);

            schedule.UserId = scheduleEditDto.UserId;
            schedule.AvailabilityId = scheduleEditDto.AvailabilityId;
            schedule.PositionId = scheduleEditDto.PositionId;

            _context.SaveChanges();

            var scheduleGetDto = new ScheduleGetDto
            {
                Id = schedule.Id,
                UserId = schedule.UserId,
                AvailabilityId = schedule.AvailabilityId,
                PositionId = schedule.PositionId
            };

            scheduleGetDto.Id = schedule.Id;

            return scheduleGetDto;
        }

        public void DeleteSchedule(int scheduleId)
        {
            var schedule = _context.Set<Schedule>().Find(scheduleId);
            _context.Set<Schedule>().Remove(schedule);
            _context.SaveChanges();
        }
      

    }

}
