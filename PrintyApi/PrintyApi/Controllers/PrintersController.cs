using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrintyApi.Models.Orders;
using PrintyApi.Models.Printers;

namespace PrintyApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class PrintersController : ControllerBase {
		private readonly PrintersRepository _printers;
		private readonly OrderRepository _orders;

		public PrintersController(PrintersRepository printers, OrderRepository orders) {
			_printers = printers;
			_orders = orders;
		}

		[HttpGet]
		public ActionResult<List<Printer>> Get() {
			return Ok(_printers.GetPrinters());
		}

		[HttpGet("{id}/orders")]
		public ActionResult<List<Order>> GetOrdersForPrinter(int id) {
			var orders = _orders.GetOrders().Where(a => a.PrinterId == id).ToList();
			return Ok(orders);
		}
	}
}