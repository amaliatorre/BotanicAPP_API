using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Route;
using BotanicAPI.Models.RouteMilestone;
using BotanicAPI.Repositories.MilestoneRepository.Interfaces;
using BotanicAPI.Repositories.RouteRepository.Interfaces;
using BotanicAPI.Repositories.UserRepository.Interfaces;
using BotanicAPI.Services.Interfaces;

namespace BotanicAPI.Services.Implements
{
    public class RouteService : IRouteService
    {
        private readonly IRouteRepository _routeRepository;
        private readonly IMilestonesRepository _minestonesRepository;
        private readonly IUserRepository _userRepository;
        public RouteService(IRouteRepository routeRepository, IMilestonesRepository milestonesRepository, IUserRepository userRepository) 
        { 
            _routeRepository = routeRepository;
            _minestonesRepository = milestonesRepository;
            _userRepository = userRepository;
        }

        public RouteEntity Create(RouteEntity routeEntity) 
        {
            try
            {
                var result = _routeRepository.Create(routeEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RouteEntity> GetAll() 
        {
            try
            {
                var result = _routeRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public RouteEntity GetById(int id)
        {
            try
            {
                var result = _routeRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RouteMilestone> GetMilestoneByRoute(int id) 
        {
            try
            {
                List<RouteMilestone> result = new List<RouteMilestone>();
                var routesEntity = _routeRepository.GetAll(); 
                foreach (var routeEntity in routesEntity) 
                {
                    RouteMilestone routeMilestone = new RouteMilestone();
                    routeMilestone.Name = _routeRepository.GetById(routeEntity.Id).Name;
                    routeMilestone.Milestone = _minestonesRepository.GetMilestoneByRoute(routeEntity.Id);
                    
                    foreach(var milestone in routeMilestone.Milestone) 
                    {
                        var checkMilestone = _userRepository.GetUserMilestoneById(milestone.Id, id);
                        if (checkMilestone.Completed) 
                        {
                            milestone.Completed = true;
                        }
                        else 
                        {
                            milestone.Completed = false;
                        }
                    }
                    result.Add(routeMilestone);
                }

                return result; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public MilestoneEntity GetMilestoneById(int id) 
        {
            try
            {
                var result = _minestonesRepository.GetById(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public RouteEntity Update(RouteEntity routeEntity) 
        {
            try
            {
                var result = _routeRepository.Update(routeEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public RouteEntity Delete(RouteEntity routeEntity)
        {
            try
            {
                var result = _routeRepository.Delete(routeEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MilestoneEntity MilestoneUpdate(MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _minestonesRepository.Update(milestoneEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MilestoneEntity MilestoneDelete(MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _minestonesRepository.Delete(milestoneEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public MilestoneEntity MilestoneCreate(MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _minestonesRepository.MilestoneCreate(milestoneEntity);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
