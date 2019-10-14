using PeopleManager.DataAccess;
using PeopleManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPeopleManager
{
	public partial class InsertNewPersonForm : Form
	{
		public InsertNewPersonForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//TODO Validation
			PersonModel model = new PersonModel();
			model.LastName = lastNameTextBox.Text;
			model.FirstName = FirstNameTextBox.Text;
			DataAccess.Connection.InsertNewPerson(model);
			//TODO sign of successful operation
		}
	}
}
