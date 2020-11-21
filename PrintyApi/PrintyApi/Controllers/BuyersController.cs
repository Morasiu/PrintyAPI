using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrintyApi.Models.Orders;

namespace PrintyApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class BuyersController : ControllerBase {
		private readonly OrderRepository _orders;

		public BuyersController(OrderRepository orders) {
			_orders = orders;
		}

		[HttpGet("{id}/orders")]
		public ActionResult<List<Order>> GetOrdersForPrinter(int id = 1) {
			var orders = _orders.GetOrders().Where(a => a.BuyerId == id).ToList();
			return Ok(orders);
		}
	}
}