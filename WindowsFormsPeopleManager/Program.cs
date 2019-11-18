using PeopleManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleManager.Test;

namespace WindowsFormsPeopleManager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			DataAccess.InitializeConnection(ConnectionType.Dapper);
			TestData.RestoreTestData();
			Application.Run(new InsertNewPersonForm());
		}
	}
}
