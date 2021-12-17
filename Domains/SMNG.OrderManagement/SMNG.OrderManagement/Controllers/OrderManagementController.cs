using Microsoft.AspNetCore.Mvc;

namespace SMNG.OrderManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderManagementController : ControllerBase
    {
        private readonly ILogger<OrderManagementController> _logger;

        public OrderManagementController(ILogger<OrderManagementController> logger)
        {
            _logger = logger;
        }



        //[HttpGet(Name = "GetOrderManagement")]
        //public IEnumerable<OrderManagement> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new OrderManagement
        //    {
        //    })
        //    .ToArray();
        //}
    }
}