using System.Collections.Generic;
using System.Linq;

namespace PrintyApi.Models.Orders {
	public class OrderRepository {
		private static List<Order> Orders { get; } = new List<Order>();


		public void AddOrder(Order order) {
			var lastId = Orders.Last().Id;
			order.Id = lastId + 1;
			Orders.Add(order);
		}

		public List<Order> GetOrders() {
			return Orders;
		}
	}
}