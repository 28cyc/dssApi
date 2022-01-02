using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dssapi.Models
{
	public class DssModel
	{
		public int uid { get; set; }
		public string District { get; set; }
		public string Village { get; set; }
		public string VillageID { get; set; }
		public int SchoolAmt { get; set; }
		public int PXMart { get; set; }
		public int HiLife { get; set; }
		public int FamiMart { get; set; }
		public int Seven { get; set; }
		public int OK { get; set; }
		public int SimilarStoreAmt { get; set; }
		public string Population { get; set; }
		public string Area { get; set; }
		public string PopulationDensity { get; set; }
		public string Attractions { get; set; }
		public string Traffic { get; set; }
		public string AvgServeP { get; set; }
		public string AvgServeAS { get; set; }
		public string IsOpen_P { get; set; }
		public string IsOpen_AS { get; set; }
	}
}
