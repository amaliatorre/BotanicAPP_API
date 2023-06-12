using BotanicAPI.Entities.Color;
using BotanicAPI.Entities.Profile;
using BotanicAPI.Repositories.ColorRepository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BotanicAPI.Repositories.ColorRepository.Implements
{
    public class ColorRepository : IColorRepository
    {
        private readonly DataContext.DataContext _context;
        public ColorRepository(DataContext.DataContext context) 
        {
            _context = context;
        }
        public ColorEntity Create(ColorEntity colorEntity)
        {
            try
            {
                _context.ColorEntities.Add(colorEntity);
                _context.SaveChanges();

                return colorEntity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
