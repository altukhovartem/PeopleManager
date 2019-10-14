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
		public void InsertNewPerson(PersonModel model)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@LastName", model.LastName);
				p.Add("@FirstName", model.FirstName);
				connection.Execute("InsertNewPerson", p, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
