
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Features.Availabilities.Dtos;

namespace StarterProject.Api.Features.Availabilities
{
    public interface IAvailabilityRepository
    {
        AvailabilityGetDto GetAvailability(int availabilityId);
        List<AvailabilityGetDto> GetAllAvailabilities();
        AvailabilityGetDto CreateAvailability(AvailabilityCreateDto availabilityCreateDto);
        AvailabilityGetDto EditAvailability(int availabilityId, AvailabilityEditDto availabilityUpdateDto);
        void DeleteAvailability(int availabilityId);


    }
    public class AvailabilityRepository : IAvailabilityRepository
    {
        private readonly DataContext _context;

        public AvailabilityRepository(DataContext context)
        {
            _context = context;
        }

        public AvailabilityGetDto GetAvailability(int availabilityId)
        {
            return _context
                .Set<Availability>()
                .Select(x => new AvailabilityGetDto
                {
                    Id = x.Id,
                    MondayAM = x.MondayAM,
                    MondayPM = x.MondayPM,
                    TuesdayAM = x.TuesdayAM,
                    TuesdayPM = x.TuesdayPM,
                    WednesdayAM = x.WednesdayAM,
                    WednesdayPM = x.WednesdayPM, 
                    ThursdayAM = x.ThursdayAM, 
                    ThursdayPM = x.ThursdayPM,
                    FridayAM = x.FridayAM,
                    FridayPM = x.FridayPM,
                    SaturdayAM = x.SaturdayAM,
                    SaturdayPM = x.SaturdayPM,
                    SundayAM = x.SundayAM,
                    SundayPM =x.SundayPM

                
                })
                //Linq syntax (its an acronym for something)
                .FirstOrDefault(x => x.Id == availabilityId);
        }

        
        //Consider usig Enum/Query with Linq to avoid using ToList to save applicaton memory
        public List<AvailabilityGetDto> GetAllAvailabilities()
        {
            return _context
                    .Set<Availability>()
                    .Select(x => new AvailabilityGetDto
                    {
                        Id = x.Id,
                        //Start = x.Start,
                        //End = x.End
                        MondayAM = x.MondayAM,
                        MondayPM = x.MondayPM,
                        TuesdayAM = x.TuesdayAM,
                        TuesdayPM = x.TuesdayPM,
                        WednesdayAM = x.WednesdayAM,
                        WednesdayPM = x.WednesdayPM,
                        ThursdayAM = x.ThursdayAM,
                        ThursdayPM = x.ThursdayPM,
                        FridayAM = x.FridayAM,
                        FridayPM = x.FridayPM,
                        SaturdayAM = x.SaturdayAM,
                        SaturdayPM = x.SaturdayPM,
                        SundayAM = x.SundayAM,
                        SundayPM = x.SundayPM
                    })
                    .ToList();
        }

        public AvailabilityGetDto CreateAvailability(AvailabilityCreateDto availabilityCreateDto)
        {
            var availability = new Availability
            {
                //Start = availabilityCreateDto.Start,
                //End = availabilityCreateDto.End,
                MondayAM = availabilityCreateDto.MondayAM,
                MondayPM = availabilityCreateDto.MondayPM,
                TuesdayAM = availabilityCreateDto.TuesdayAM,
                TuesdayPM = availabilityCreateDto.TuesdayPM,
                WednesdayAM = availabilityCreateDto.WednesdayAM,
                WednesdayPM = availabilityCreateDto.WednesdayPM,
                ThursdayAM = availabilityCreateDto.ThursdayAM,
                ThursdayPM = availabilityCreateDto.ThursdayPM,
                FridayAM = availabilityCreateDto.FridayAM,
                FridayPM = availabilityCreateDto.FridayPM,
                SaturdayAM = availabilityCreateDto.SaturdayAM,
                SaturdayPM = availabilityCreateDto.SaturdayPM,
                SundayAM = availabilityCreateDto.SundayAM,
                SundayPM = availabilityCreateDto.SundayPM

            };
            //INheriting from EF dbcontext to access
            //
            _context.Availabilities.Add(availability);
            
            _context.SaveChanges();

            var availabilityGetDto = new AvailabilityGetDto
            {
                Id = availability.Id,
                //Start = availability.Start,
                //End = availability.End
                MondayAM = availability.MondayAM,
                MondayPM = availability.MondayPM,
                TuesdayAM = availability.TuesdayAM,
                TuesdayPM = availability.TuesdayPM,
                WednesdayAM = availability.WednesdayAM,
                WednesdayPM = availability.WednesdayPM,
                ThursdayAM = availability.ThursdayAM,
                ThursdayPM = availability.ThursdayPM,
                FridayAM = availability.FridayAM,
                FridayPM = availability.FridayPM,
                SaturdayAM = availability.SaturdayAM,
                SaturdayPM = availability.SaturdayPM,
                SundayAM = availability.SundayAM,
                SundayPM = availability.SundayPM

            };
            return availabilityGetDto;
        }

        public AvailabilityGetDto EditAvailability(int availabilityId, AvailabilityEditDto availabilityEditDto)
        {
            var availability = _context.Set<Availability>().Find(availabilityId);
            //availability.Start = availabilityEditDto.Start;
            //availability.End = availabilityEditDto.End;
            availability.SundayAM = availabilityEditDto.SundayAM;
            availability.SundayPM = availabilityEditDto.SundayPM;
            availability.MondayAM = availabilityEditDto.MondayAM;
            availability.MondayPM = availabilityEditDto.MondayPM;
            availability.TuesdayAM = availabilityEditDto.TuesdayPM;
            availability.TuesdayPM = availabilityEditDto.TuesdayPM;
            availability.WednesdayAM = availabilityEditDto.WednesdayAM;
            availability.WednesdayAM = availabilityEditDto.WednesdayAM;
            availability.ThursdayAM = availabilityEditDto.ThursdayAM;
            availability.ThursdayPM = availabilityEditDto.ThursdayPM;
            availability.FridayAM = availabilityEditDto.FridayAM;
            availability.FridayPM = availabilityEditDto.FridayPM;
            availability.SaturdayAM = availabilityEditDto.SaturdayAM;
            availability.SaturdayPM = availabilityEditDto.SaturdayPM;
 
            _context.SaveChanges();

            var availabilityGetDto = new AvailabilityGetDto
            {
                Id = availability.Id,
                MondayAM = availability.MondayAM,
                MondayPM = availability.MondayPM,
                TuesdayAM = availability.TuesdayAM,
                TuesdayPM = availability.TuesdayPM,
                WednesdayAM = availability.WednesdayAM,
                WednesdayPM = availability.WednesdayPM,
                ThursdayAM = availability.ThursdayAM,
                ThursdayPM = availability.ThursdayPM,
                FridayAM = availability.FridayAM,
                FridayPM = availability.FridayPM,
                SaturdayAM = availability.SaturdayAM,
                SaturdayPM = availability.SaturdayPM,
                SundayAM = availability.SundayAM,
                SundayPM = availability.SundayPM
            };

            availabilityGetDto.Id = availability.Id;

            return availabilityGetDto;
        }
        //May need to add some more stuff here
        public void DeleteAvailability(int availabilityId)
        {
            var availability = _context.Set<Availability>().Find(availabilityId);
            _context.Set<Availability>().Remove(availability);
            _context.SaveChanges();
        }
    }
}