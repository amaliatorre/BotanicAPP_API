using BotanicAPI.Entities.Avatar;
using BotanicAPI.Entities.Color;
using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Profile;
using BotanicAPI.Models.LoginModel;
using BotanicAPI.Repositories.ProfileRepository.Interfaces;

namespace BotanicAPI.Repositories.ProfileRepository.Implements
{
    public class ProfileRepository : IProfileRepository
    {

        private readonly DataContext.DataContext _context;

        public ProfileRepository(DataContext.DataContext context)
        {
            _context = context;
        }

        public ProfileEntity Create(ProfileEntity profileEntity)
        {
            try
            {
                _context.ProfileEntities.Add(profileEntity);
                _context.SaveChanges();

                return profileEntity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public List<ProfileEntity> GetAllByUserId(int id)
        {
            try
            {
                var result = _context.ProfileEntities.Where(x => x.UserId == id).ToList();
                foreach(var item in result) 
                {
                    item.Avatar = _context.AvatarEntities.Where(x => x.Id == item.AvatarId).FirstOrDefault();
                    item.Color = _context.ColorEntities.Where(x => x.Id == item.ColorId).FirstOrDefault();
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
