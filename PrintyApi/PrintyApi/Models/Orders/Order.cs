using System.Collections.Generic;
using PrintyApi.Models.Printers;

namespace PrintyApi.Models.Orders {
	public class Order {
		public int Id { get; set; }
		public int BuyerId { get; set; } = 1;
		public int PrinterId { get; set; }
		public List<PrintInfo> PrintInfos { get; set; }
	}

	public class PrintInfo {
		public Dimension Dimension { get; set; }
		public PrintSize Size { get; set; }
		public PrintColor Color { get; set; }
		public PrintMaterial PrintMaterial { get; set; }
		public decimal Price { get; set; }
		public int Copies { get; set; }
		public string FileId { get; set; }
	}
}