﻿using System;
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
		public int InsertPerson(PersonModel model)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@LastName", model.LastName);
				p.Add("@FirstName", model.FirstName);
				p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("InsertNewPerson", p, commandType: CommandType.StoredProcedure);
				model.ID = p.Get<int>("@ID");
				return model.ID;
			}
		}

		public void InsertAddress(PersonModel personModel, AddressModel addressModel)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@PersonID", personModel.ID);
				p.Add("@Country", addressModel.Country);
				p.Add("@State", addressModel.State);
				p.Add("@City", addressModel.City);
				p.Add("@Street", addressModel.Street);
				p.Add("@ZIPCode", addressModel.ZIPCode);

				connection.Execute("InsertNewAddress", p, commandType: CommandType.StoredProcedure);
			}
		}

		public List<PersonModel> GetListOfPeople()
		{
			List<PersonModel> listOfPersonModel;
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				string sqlText = "select * from People";
				listOfPersonModel = connection.Query<PersonModel>(sqlText, p, commandType: CommandType.Text).ToList();
				return listOfPersonModel;
			}
		}

		public List<AddressModel> GetListOfAddresses()
		{
			List<AddressModel> listOfAddresses;
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				string sqlText = "select * from Address";
				listOfAddresses = connection.Query<AddressModel>(sqlText, p, commandType: CommandType.Text).ToList();
				return listOfAddresses;
			}
		}
	}
}
