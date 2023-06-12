using BotanicAPI.Entities.Route;
using BotanicAPI.Entities.User;
using BotanicAPI.Repositories.RouteRepository.Interfaces;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Microsoft.AspNetCore.Http;



namespace BotanicAPI.Repositories.RouteRepository.Implements
{
    public class RouteRepository : IRouteRepository
    {
        private readonly DataContext.DataContext _context;
        public RouteRepository(DataContext.DataContext context) 
        { 
            _context = context;
        }


        public RouteEntity Create(RouteEntity routeEntity)
        {
            try
            {
                _context.RouteEntities.Add(routeEntity);
                _context.SaveChanges();

                return routeEntity;
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
                var result = _context.RouteEntities.ToList();
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
                var result = _context.RouteEntities.Find(id);
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
                var result = _context.RouteEntities.Update(routeEntity);
                _context.SaveChanges();
                return routeEntity;
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
                var result = _context.RouteEntities.Remove(routeEntity);
                _context.SaveChanges();
                return routeEntity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
