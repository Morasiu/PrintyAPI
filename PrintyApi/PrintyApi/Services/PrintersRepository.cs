using System.Collections.Generic;
using PrintyApi.Models.Printers;

namespace PrintyApi.Services {
	public class PrintersRepository {
		public List<Printer> GetPrinters() {
			var printers = new List<Printer> {
				new Printer {
					Name = "Kasia",
					Email = "kasia@gmail.com",
					Latitude = 50.050446342506014,
					Longitude = 19.94278579652964,
					PhoneNumber = "123456789",
					Address = new Address {
						StreetNumber = "15", 
						Street = "Krakowska", 
						ZipCode = "31-062",
						City = "Kraków"
					}
				},
				new Printer {
					Name = "Cyfra 7. Druk cyfrowy Solwent",
					Email = "cyfra@gmail.com",
					Latitude = 50.05656237616683,
					Longitude = 19.935061177926688,
					PhoneNumber = "123456789",
					Address = new Address {
						StreetNumber = "1",
						HouseNumber = "2",
						Street = "Straszewskiego", 
						ZipCode = "31-101",
						City = "Kraków"
					}
				},
				new Printer {
					Name = "Michał",
					Email = "michal@gmail.com",
					Latitude = 50.05656237616528, 
					Longitude = 19.94217038753566,
					PhoneNumber = "123456789",
					Address = new Address {
						StreetNumber = "6",
						Street = "Świętego Sebastiana", 
						ZipCode = "31-049",
						City = "Kraków"
					}
				}
			};

			for (int i = 0; i < printers.Count; i++) {
				printers[i].Id = i + 1;
			}

			return printers;
		}
	}
}