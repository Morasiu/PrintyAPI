using System;
using System.Collections.Generic;
using System.Linq;
using PrintyApi.Models.Printers;

namespace PrintyApi.Models.Orders {
	public class OrderRepository {
		private static List<Order> Orders { get; } = new List<Order>() {
			new Order {
				Id = 1,
				PrinterId = 1,
				PrintInfos = new List<PrintInfo> {
					new PrintInfo {
						Dimension = Dimension.TwoDimensional,
						Size = PrintSize.A4,
						Color = PrintColor.BlackAndWhite,
						PrintMaterial = PrintMaterial.StandardPaper,
						Price = 0.20m,
						Copies = 1,
						FileId = Guid.NewGuid().ToString("N")
					}
				}
			}
		};


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