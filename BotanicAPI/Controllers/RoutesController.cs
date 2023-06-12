using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.Route;
using BotanicAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BotanicAPI.Controllers
{
    public class RoutesController : ControllerBase
    {
        private readonly IRouteService _routeService;
        private readonly IUserService _userService;
        public RoutesController(IRouteService routeService, IUserService userService) 
        { 
            _routeService = routeService;
            _userService = userService;
        }

        // GET: UserController/Create
        [HttpPost("routes/create")]
        public IActionResult Create([FromBody] RouteEntity route)
        {
            try
            {
                var result = _routeService.Create(route);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("routes/getall")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _routeService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("routes")]
        public IActionResult GetById([FromBody]int id)
        {
            try
            {
                var result = _routeService.GetById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("milestones/routes")]
        public IActionResult GetRouteByMilestonesId([FromBody] int id)
        {
            try
            {
                var result = _routeService.GetMilestoneByRoute(id); 

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("routes/update")]
        public IActionResult Update([FromBody] RouteEntity routeEntity)
        {
            try
            {
                var result = _routeService.Update(routeEntity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("routes/delete")]
        public IActionResult Delete([FromBody] RouteEntity routeEntity)
        {
            try
            {
                var result = _routeService.Delete(routeEntity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("milestones/delete")]
        public IActionResult MilestoneDelete([FromBody] MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _routeService.MilestoneDelete(milestoneEntity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("milestones/update")]
        public IActionResult MilestoneUpdate([FromBody] MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _routeService.MilestoneUpdate(milestoneEntity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("milestones/create")]
        public IActionResult MilestoneCreate([FromBody] MilestoneEntity milestoneEntity)
        {
            try
            {
                var result = _routeService.MilestoneCreate(milestoneEntity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
