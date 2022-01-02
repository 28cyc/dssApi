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
		[HttpPost]
		public JsonResult Post(DssModel model)
		{
			DssModel data = dac.readDb(model.VillageID);
			//return JsonConvert.SerializeObject(data);
			return Json(data);
		}
	}
}
