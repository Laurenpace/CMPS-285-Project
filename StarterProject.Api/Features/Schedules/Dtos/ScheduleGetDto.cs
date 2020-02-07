using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Schedules.Dtos
{
    public class ScheduleGetDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AvailabilityId { get; set; }
        public int? PositionId { get; set; }
    }
}
