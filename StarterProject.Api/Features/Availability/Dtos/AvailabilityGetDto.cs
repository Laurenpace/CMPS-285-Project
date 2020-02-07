
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Availabilities.Dtos
{
    public class AvailabilityGetDto
    {
        public int Id { get; set; }
        //public DateTime Start { get; set; }
        //public DateTime End { get; set; }
        public bool MondayAM { get; set; }
        public bool MondayPM { get; set; }
        public bool TuesdayAM { get; set; }
        public bool TuesdayPM { get; set; }
        public bool WednesdayAM { get; set; }
        public bool WednesdayPM { get; set; }
        public bool ThursdayAM { get; set; }
        public bool ThursdayPM { get; set; }
        public bool FridayAM { get; set; }
        public bool FridayPM { get; set; }
        public bool SaturdayAM { get; set; }
        public bool SaturdayPM { get; set; }
        public bool SundayAM { get; set; }
        public bool SundayPM { get; set; }

    }
}
