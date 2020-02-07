using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Common;
using StarterProject.Api.Data;
using StarterProject.Api.Data.Entites;
using StarterProject.Api.Dtos.Positions;
using StarterProject.Api.Features.Positions.Dtos;
using StarterProject.Api.Security;

namespace StarterProject.Api.Features.Positions
{
    public interface IPositionRepository
    {
        PositionGetDto GetPosition(int positionId);
        List<PositionGetDto> GetAllPositions();
        PositionGetDto CreatePosition(PositionCreateDto positionCreateDto);
        PositionGetDto EditPosition(int positionId, PositionEditDto positionUpdateDto);
        void DeletePosition(int positionId);
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly DataContext _context;

        public PositionRepository(DataContext context)
        {
            _context = context;
        }

        public PositionGetDto GetPosition(int positionId)
        {
            return _context
                .Set<Position>()
                .Select(x => new PositionGetDto
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .FirstOrDefault(x => x.Id == positionId);
        }

        public List<PositionGetDto> GetAllPositions()
        {
            return _context
                .Set<Position>()
                .Select(x => new PositionGetDto
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();
        }

        public PositionGetDto CreatePosition(PositionCreateDto positionCreateDto)
        {
            var position = new Position
            {
                Name = positionCreateDto.Name
            };

            _context.Set<Position>().Add(position);
            _context.SaveChanges();

            var positionGetDto = new PositionGetDto
            {
                Id = position.Id,
                Name = position.Name
            };

            return positionGetDto;
        }

        public PositionGetDto EditPosition(int positionId, PositionEditDto positionEditDto)
        {
            var position = _context.Set<Position>().Find(positionId);

            position.Name = positionEditDto.Name;

            _context.SaveChanges();

            var positionGetDto = new PositionGetDto
            {
                Id = position.Id,
                Name = position.Name
            };

            return positionGetDto;
        }

        public void DeletePosition(int positionId)
        {
            var position = _context.Set<Position>().Find(positionId);
            _context.Set<Position>().Remove(position);
            _context.SaveChanges();
        }
    }
}
