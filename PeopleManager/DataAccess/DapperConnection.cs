using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PeopleManager.Model;

namespace PeopleManager.DataAccess
{
	public class DapperConnection : IDataConnection
	{


		public void InsertPerson(PersonModel model)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@LastName", model.LastName);
				p.Add("@FirstName", model.FirstName);
				p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("InsertNewPerson", p, commandType: CommandType.StoredProcedure);
				model.Id = p.Get<int>("@ID");
			}
		}

		public void InsertAddress(PersonModel personModel, AddressModel addressModel)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@PersonID", personModel.Id);
				p.Add("@Country", addressModel.Country);
				p.Add("@State", addressModel.State);
				p.Add("@City", addressModel.City);
				p.Add("@Street", addressModel.Street);
				p.Add("@ZIPCode", addressModel.ZIPCode);

				connection.Execute("InsertNewAddress", p, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
