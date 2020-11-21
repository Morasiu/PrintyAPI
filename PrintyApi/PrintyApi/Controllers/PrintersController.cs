using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PrintyApi.Models.Printers;
using PrintyApi.Services;

namespace PrintyApi.Controllers {
	[ApiController]
	[Route("[controller]")]
	public class PrintersController : ControllerBase {
		private readonly PrintersRepository _printers;

		public PrintersController(PrintersRepository printers) {
			_printers = printers;
		}

		[HttpGet]
		public ActionResult<List<Printer>> Get() {
			return Ok(_printers.GetPrinters());
		}
	}
}