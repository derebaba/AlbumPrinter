using AlbumPrinter.Core.Interfaces;
using AlbumPrinter.Core.Models;
using AlbumPrinter.Infrastructure.Persistence;
using Effort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AlbumPrinter.Web.Controllers
{
    public class OrdersController : ApiController
    {
        private readonly IOrderRepository OrderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        [HttpGet]
        public IHttpActionResult Get(Guid id)
        {
            Order order = OrderRepository.GetById(id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }
        
        [HttpPost]
        public IHttpActionResult Post([FromBody] Order order)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Order insertedOrder = OrderRepository.Add(order);

            return Ok(insertedOrder);
        }
    }
}
