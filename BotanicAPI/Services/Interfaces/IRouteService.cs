using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Route;
using BotanicAPI.Models.RouteMilestone;

namespace BotanicAPI.Services.Interfaces
{
    public interface IRouteService
    {
        RouteEntity Create(RouteEntity routeEntity);
        List<RouteEntity> GetAll();
        RouteEntity GetById(int id);
        List<RouteMilestone> GetMilestoneByRoute(int id);
        MilestoneEntity GetMilestoneById(int id);
        RouteEntity Update(RouteEntity routeEntity);
        RouteEntity Delete(RouteEntity routeEntity);
        MilestoneEntity MilestoneCreate(MilestoneEntity milestoneEntity);
        MilestoneEntity MilestoneDelete(MilestoneEntity milestoneEntity);
        MilestoneEntity MilestoneUpdate(MilestoneEntity milestoneEntity);
    }
}
