using System.Collections.Generic;

namespace PrintyApi.Models.Printers {
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
					Name = "Drukarnia Joasia",
					Email = "cyfra@gmail.com",
					Latitude = 50.05351888215761, 
					Longitude = 19.94331651530966,
					PhoneNumber = "123456789",
					ServiceTypes = new [] { ServiceType.Print2D },
					Services = new List<PrintService> {
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A1,
							Price = 10m
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A2,
							Price = 8m
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A3,
							Price = 6
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A4,
							Price = 2
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A5,
							Price = 1
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A1,
							Price = 20m
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A2,
							Price = 18m
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A3,
							Price = 16
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A4,
							Price = 12
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.Colored,
							PrintMaterial = PrintMaterial.StandardPaper,
							Size = PrintSize.A5,
							Price = 4
						},
						new PrintService {
							Dimension = Dimension.TwoDimensional,
							Color = PrintColor.BlackAndWhite,
							PrintMaterial = PrintMaterial.BoldPaper,
							Size = PrintSize.A4,
							Price = 2.50m
						},
					},
					Address = new Address {
						StreetNumber = "1",
						HouseNumber = "2",
						Street = "Straszewskiego", 
						ZipCode = "31-101",
						City = "Kraków"
					},
				},
				new Printer {
					Name = "Cyfra 7. Druk cyfrowy Solwent",
					Email = "cyfra@gmail.com",
					Latitude = 50.05656237616683,
					Longitude = 19.935061177926688,
					PhoneNumber = "123456789",
					ServiceTypes = new [] { ServiceType.Print2D },
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
					},
				},
				new Printer {
					Name = "3Dx - wynajem drukarek",
					Email = "druk@gmail.com",
					Latitude = 50.0576688239084, 
					Longitude = 19.938658445788747,
					PhoneNumber = "123456789",
					ServiceTypes = new [] { ServiceType.Print3D },
					Address = new Address {
						StreetNumber = "46",
						Street = "Grodzka", 
						ZipCode = "31-044",
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
						},
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticAbs,
							Color = PrintColor.Orange,
							Size = PrintSize.To6Cm,
							Price = 10m,
						},
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticAbs,
							Color = PrintColor.Orange,
							Size = PrintSize.To9Cm,
							Price = 15m,
						},
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticPla,
							Color = PrintColor.PlasticGray,
							Size = PrintSize.To6Cm,
							Price = 8m,
						},
						new PrintService {
							Dimension = Dimension.ThreeDimensional,
							PrintMaterial = PrintMaterial.PlasticPla,
							Color = PrintColor.PlasticGray,
							Size = PrintSize.To9Cm,
							Price = 13.50m,
						}
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