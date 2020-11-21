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
					ServiceTypes = new [] { ServiceType.Print2D },
					Address = new Address {
						StreetNumber = "15", 
						Street = "Krakowska", 
						ZipCode = "31-062",
						City = "Kraków"
					},
					Services = new List<PrintService> {
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Size = PrintSize.A4,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Price = 0.20m
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Size = PrintSize.A4,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Price = 0.60m
						}
					}
				},
				new Printer {
					Name = "Michał - druk 3D",
					Email = "michal@gmail.com",
					Latitude = 50.05656237616528, 
					Longitude = 19.94217038753566,
					PhoneNumber = "123456789",
					ServiceTypes = new [] { ServiceType.Print3D },
					Address = new Address {
						StreetNumber = "6",
						Street = "Świętego Sebastiana", 
						ZipCode = "31-049",
						City = "Kraków"
					},
					Services = new List<PrintService> {
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticAbs,
							Color = PrintColor.PlasticGray,
							Size = PrintSize.To6Cm,
							Price = 10m,
						},
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticAbs,
							Color = PrintColor.PlasticGray,
							Size = PrintSize.To9Cm,
							Price = 15m,
						}
					}
				},
				new Printer {
					Name = "Cyfra 7. Druk cyfrowy Solwent",
					Email = "cyfra@gmail.com",
					Latitude = 50.05656237616683,
					Longitude = 19.935061177926688,
					PhoneNumber = "123456789",
					ServiceTypes = new [] { ServiceType.Scanner },
					Services = new List<PrintService> {
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.BoldPaper,
							Size = PrintSize.A4,
							Price = 0.70m
						}
					},
					Address = new Address {
						StreetNumber = "1",
						HouseNumber = "2",
						Street = "Straszewskiego", 
						ZipCode = "31-101",
						City = "Kraków"
					}
				},
			};

			for (int i = 0; i < printers.Count; i++) {
				printers[i].Id = i + 1;
			}

			return printers;
		}
	}
}