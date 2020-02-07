using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Data.Entites
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Schedule> Schedules { get; set; }
    }
}
