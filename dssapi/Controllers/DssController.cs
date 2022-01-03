using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dssapi.Models;
using dssapi.Dac;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dssapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DssController : Controller
	{
		DssDac dac = new DssDac();
		//https://localhost:44321/api/dss
		[HttpGet("{VillageID}")]
		public JsonResult Post(string VillageID)
		{
			DssModel data = dac.readDb(VillageID);
			return Json(data);
		}
	}
}
