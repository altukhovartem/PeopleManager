using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PeopleManager.DataAccess;
using System.Configuration;


namespace PeopleManager.Test
{
    public class TestData
    {
		public static void RestoreTestData()
		{
			using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
			{
				string tables = File.ReadAllText(@"C:\myRepos\PeopleManager\PeopleManager.Test\SQL\CreateTables.txt");
				connection.QueryMultiple(tables);
			}

			using (IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString))
			{
				string testData = File.ReadAllText(@"C:\myRepos\PeopleManager\PeopleManager.Test\SQL\InsertData.txt");
				connection.QueryMultiple(testData);
			}
		}
    }
}
