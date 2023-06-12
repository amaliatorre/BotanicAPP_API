using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.User;
using BotanicAPI.Repositories.UserRepository.Interfaces;

namespace BotanicAPI.Repositories.UserRepository.Implements
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext.DataContext _context;

        public UserRepository(DataContext.DataContext context) 
        { 
            _context = context;
        }

        public UserEntity Create(UserEntity userEntity) 
        {
            try
            {
                _context.Users.Add(userEntity);
                _context.SaveChanges();
                
                return userEntity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UserEntity Login(UserEntity userEntity) 
        {
            try
            {
                var result = _context.Users.FirstOrDefault(x => x.Password == userEntity.Password && x.Email == userEntity.Email);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public UserMilestonesEntity GetUserMilestoneById(int id, int userId)
        {
            try
            {
                var result = _context.UserMilestonesEntities.Where(x => x.MilestoneId == id && x.UserId == userId).FirstOrDefault();
                if (result == null) 
                {
                    result = new UserMilestonesEntity();
                    result.UserId = userId;
                    result.Completed = false;
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
