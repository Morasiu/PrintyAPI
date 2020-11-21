namespace PrintyApi.Models.Printers {
	public class Printer {
		public int Id { get; set; }
		public string Name { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public Address Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
	}

	public class Address {
		public string ZipCode { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string StreetNumber { get; set; }
		public string HouseNumber { get; set; }
	}
}