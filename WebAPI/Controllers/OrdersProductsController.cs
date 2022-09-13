using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersProductsController : ControllerBase
    {
        IOrderProductService _orderProductService;

        public OrdersProductsController(IOrderProductService orderProductService)
        {
            _orderProductService = orderProductService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderProductService.GetAll();
            return Ok(result.Data);
        }
        [HttpGet("get")]
        public IActionResult Get(int id)
        {
            var result = _orderProductService.Get(id);
            if (!result.Success)
            {
                return BadRequest(result.Data);
            }
            return Ok(result.Data);
        }
        [HttpPost("add")]
        public IActionResult Add(OrderProduct orderProduct)
        {
            var result = _orderProductService.Add(orderProduct);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(OrderProduct orderProduct)
        {
            var result = _orderProductService.Update(orderProduct);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }
            return Ok(result.Message);
        }
        [HttpGet("delete")]
        public IActionResult Delete(int id)
        {
            var result = _orderProductService.Delete(id);
            if (!result.Success)
            {
                return BadRequest(result.Success);
            }
            return Ok(result.Success);
        }
    }

}
