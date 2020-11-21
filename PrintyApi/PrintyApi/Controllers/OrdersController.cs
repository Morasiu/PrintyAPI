using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PrintyApi.Models.Orders;

namespace PrintyApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class OrdersController : ControllerBase {
		private readonly OrderRepository _orders;
		private readonly IMapper _mapper;

		public OrdersController(OrderRepository orders, IMapper mapper) {
			_orders = orders;
			_mapper = mapper;
		}

		[HttpPost]
		public ActionResult Post(OrderPost orderPost) {
			var order = _mapper.Map<Order>(orderPost);
			_orders.AddOrder(order);
			return Ok();
		}

		//[HttpGet]
		//public ActionResult<List<Printer>> Get() {
		//	return Ok(_printers.GetPrinters());
		//}
	}
}