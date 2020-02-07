using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarterProject.Api.Features.Users;
using StarterProject.Api.Features.Availabilities;
using StarterProject.Api.Features.Positions;

namespace StarterProject.Api.Data.Entites
{
    public class Schedule
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int AvailabilityId { get; set; }
        public Availability Availability { get; set; }

        public int? PositionId { get; set; }
        public Position Position { get; set; }
    }
}
