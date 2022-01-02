using dssapi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace dssapi.Dac
{
	public class DssDac
	{
		public DssModel readDb(string VillageID)
		{
			List<DssModel> result = new List<DssModel>();
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source=dssfinal.database.windows.net;Initial Catalog=DSSFINAL;User id=DSSFinal;Password=Dssonazure1;";
			conn.Open();

			string sqlString = $@"select * from taoyuan where VillageID = @VillageID";
			SqlCommand command = new SqlCommand(sqlString, conn);
			command.Parameters.AddWithValue("@VillageID", VillageID);
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				#region 笨蛋方法
				while (reader.Read())
				{				
					var element = new DssModel();
					element.uid = int.Parse(reader["uid"].ToString());
					element.District = reader["District"].ToString();
					element.Village = reader["Village"].ToString();
					element.VillageID = reader["VillageID"].ToString();
					element.SchoolAmt = int.Parse(reader["SchoolAmt"].ToString());
					element.PXMart = int.Parse(reader["PXMart"].ToString());
					element.HiLife = int.Parse(reader["HiLife"].ToString());
					element.FamiMart = int.Parse(reader["FamiMart"].ToString());
					element.Seven = int.Parse(reader["Seven"].ToString());
					element.OK = int.Parse(reader["OK"].ToString());
					element.SimilarStoreAmt = int.Parse(reader["SimilarStoreAmt"].ToString());
					element.Population = reader["Population"].ToString();
					element.Area = reader["Area"].ToString();
					element.PopulationDensity = reader["PopulationDensity"].ToString();
					element.Attractions = reader["Attractions"].ToString();
					element.Traffic = reader["Traffic"].ToString();
					element.AvgServeP = reader["AvgServeP"].ToString();
					element.AvgServeAS = reader["AvgServeAS"].ToString();
					element.IsOpen_P = reader["IsOpen_P"].ToString();
					element.IsOpen_AS = reader["IsOpen_AS"].ToString();
					//etc...
					result.Add(element);					
				}
				#endregion
			}
			conn.Close();
			return result.FirstOrDefault(); 
		}
	}
}
