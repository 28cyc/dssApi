using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dssapi.Models;
using dssapi.Dac;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace dssapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DssController : Controller
	{
		DssDac dac = new DssDac();
		//https://localhost:44321/api/dss/store/6800002075
		//以同性質商店為基準
		[HttpGet("store/{VillageID}")]
		public JsonResult Store(string VillageID)
		{
			DssModel data = dac.readDb(VillageID);
			//var model = new DssModel()
			//{
			//	Village = "仁和里",
			//	VillageID = "6800002075",
			//	SchoolAmt = 0,
			//	Population = "4432",
			//	Area = "0.196",
			//	PopulationDensity = "22612.2448979592",
			//	Attractions = "0",
			//	Traffic = "21460.63636",
			//	AvgServeP = "4432",
			//	AvgServeAS = "0"
			//};
			return Json(data);
		}

		//https://localhost:44321/api/dss/people/6800002075
		//以人口為基準
		[HttpGet("people/{VillageID}")]
		public JsonResult People(string VillageID)
		{
			DssModel data = dac.readDb(VillageID);
			return Json("人口");
		}

		//https://localhost:44321/api/dss/school/6800002075
		//以景點、學校為基準
		[HttpGet("school/{VillageID}")]
		public JsonResult School(string VillageID)
		{
			DssModel data = dac.readDb(VillageID);
			return Json("景點、學校");
		}
	}
}
