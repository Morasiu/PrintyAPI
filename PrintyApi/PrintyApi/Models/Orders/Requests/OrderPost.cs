using System;
using System.Collections.Generic;

namespace PrintyApi.Models.Orders {
	public class OrderPost {
		public DateTimeOffset TakeawayTime { get; set; }
		public int PrinterId { get; set; }
		public List<PrintInfo> PrintInfos { get; set; }
	}
}