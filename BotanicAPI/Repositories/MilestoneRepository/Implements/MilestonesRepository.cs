using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Route;
using BotanicAPI.Repositories.MilestoneRepository.Interfaces;

namespace BotanicAPI.Repositories.MilestoneRepository.Implements
{
    public class MilestonesRepository : IMilestonesRepository
    {
        private readonly DataContext.DataContext _context;

        public MilestonesRepository(DataContext.DataContext context)
        {
            _context = context;
        }

        public bool GetByMilestoneId(int id)
        {
            try
            {
                var result = _context.UserMilestonesEntities.Where(x => x.MilestoneId == id).FirstOrDefault().Completed;

                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UserMilestonesEntity Create(UserMilestonesEntity userMilestonesEntity)
        {
            try
            {
                _context.UserMilestonesEntities.Add(userMilestonesEntity);
                _context.SaveChanges();

                return userMilestonesEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UserMilestonesEntity> GetAllByUserId(int id) 
        {
            try
            {
                var result = _context.UserMilestonesEntities.Where(x => x.UserId == id).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MilestoneEntity GetById(int id) 
        {
            try
            {
                var result = _context.MilestoneEntities.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<MilestoneEntity> GetMilestoneByRoute(int routeId) 
        {
            try
            {
                var result = _context.MilestoneEntities.Where(x => x.RouteId == routeId).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MilestoneEntity Update(MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _context.MilestoneEntities.Update(milestoneEntity);
                _context.SaveChanges();
                return milestoneEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MilestoneEntity Delete(MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _context.MilestoneEntities.Remove(milestoneEntity);
                _context.SaveChanges();
                return milestoneEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MilestoneEntity MilestoneCreate(MilestoneEntity MilestonesEntity) 
        {
            try
            {
                _context.MilestoneEntities.Add(MilestonesEntity);
                _context.SaveChanges();

                return MilestonesEntity;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
