using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.DataAccess
{
	public class DataAccess
	{
		public static IDataConnection Connection { get; set; }
		public static string ConnectionString { get => ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString; }

		public static void InitializeConnection(ConnectionType type)
		{
			switch(type)
			{
				case ConnectionType.Dapper:
				{
					Connection = new DapperConnection();
					break;
				}
			}
		}

	}

	public enum ConnectionType
	{
		Dapper
	}
}
