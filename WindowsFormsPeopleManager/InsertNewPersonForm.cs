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
			PersonModel person = new PersonModel();
			person.LastName = lastNameTextBox.Text;
			person.FirstName = FirstNameTextBox.Text;

			AddressModel address = new AddressModel();
			address.Country = countryTextbox.Text;
			address.State = stateTextBox.Text;
			address.City = cityTextbox.Text;
			address.Street = streetTextbox.Text;
			address.ZIPCode = Convert.ToInt32(zIPCodeTextBox.Text);


			DataAccess.Connection.InsertPerson(person);
			DataAccess.Connection.InsertAddress(person, address);
			//TODO sign of successful operation
		}
	}
}
