using BotanicAPI.Entities.Route;

namespace BotanicAPI.Repositories.RouteRepository.Interfaces
{
    public interface IRouteRepository
    {
        RouteEntity Create(RouteEntity routeEntity);
        List<RouteEntity> GetAll();
        RouteEntity GetById(int id);
        RouteEntity Update(RouteEntity routeEntity);
        RouteEntity Delete(RouteEntity routeEntity);
    }
}
