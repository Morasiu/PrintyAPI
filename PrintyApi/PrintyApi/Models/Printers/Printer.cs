using System;
using System.Collections.Generic;

namespace PrintyApi.Models.Printers {
	public class Printer {
		public int Id { get; set; }
		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public Address Address { get; set; }
		public List<PrintService> Services { get; set; }
	}

	public class PrintService {
		public Dimension Dimension { get; set; }
		public PrintSize Size { get; set; }
		public PrintColor Color { get; set; }
		public PrintMaterial PrintMaterial { get; set; }
		public decimal Price { get; set; }
	}

	public enum PrintMaterial {
		Error = 0,
		StandardPaper = 101,
		BoldPaper = 102,
		PlasticAbs = 201,
		PlasticPla = 202
	}

	public enum PrintColor {
		Error = 0,
		BlackAndWhite = 1,
		Colored = 2,
		PlasticGray = 3,
		Orange = 4,
		Other = 100
	}

	public enum PrintSize {
		Error = 0,
		A1 = 100,
		A2 = 102,
		A3 = 103,
		A4 = 104,
		A5 = 105,
		To6Cm = 201,
		To9Cm = 202
	}

	public enum Dimension {
		Error = 0,
		TwoDimensional = 1,
		ThreeDimensional = 2
	}

	public class Address {
		public string ZipCode { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string StreetNumber { get; set; }
		public string HouseNumber { get; set; }
	}
}