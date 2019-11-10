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
		public static int currentPersonID = 0;

		public InsertNewPersonForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			//TODO Validation
			PersonModel person = new PersonModel();
			person.LastName = lastNameTextBox.Text;
			person.FirstName = firstNameTextBox.Text;

			AddressModel address = new AddressModel();
			address.Country = countryTextbox.Text;
			address.State = stateTextBox.Text;
			address.City = cityTextbox.Text;
			address.Street = streetTextbox.Text;
			address.ZIPCode = Convert.ToInt32(zIPCodeTextBox.Text);


			currentPersonID = DataAccess.Connection.InsertPerson(person);
			DataAccess.Connection.InsertAddress(person, address);
			//TODO sign of successful operation
		}

		private void InsertButton_Click(object sender, EventArgs e)
		{
			bool textBoxIsNotEmpty = false;
			textBoxIsNotEmpty = CheckTextBoxesForData(this.Controls);

			if (textBoxIsNotEmpty)
			{
				DialogResult result = MessageBox.Show("Are you sure you want to discard you changes?", "123", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
				{
					ResetAllTextBoxes(this.Controls);
					currentPersonID = 0;
				}
			}
		}

		private bool CheckTextBoxesForData(Control.ControlCollection controls)
		{
			bool textBoxIsNotEmpty = false;
			foreach (Control c in controls)
			{
				if(c.Controls.Count == 0)
				{
					if (c is TextBox)
					{
						if (c.Text.Length > 0)
						{
							textBoxIsNotEmpty = true;
						}
					}
				}
				else
				{
					CheckTextBoxesForData(c.Controls);
				}
			}

			return textBoxIsNotEmpty;
		}

		private void ResetAllTextBoxes(Control.ControlCollection controls)
		{
			foreach (Control c in controls)
			{
				if (c.Controls.Count == 0)
				{
					if (c is TextBox)
					{
						if (c.Text.Length > 0)
						{
							c.ResetText();
						}
					}
				}
				else
				{
					ResetAllTextBoxes(c.Controls);
				}
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{

		}

		private void nextPersonButton_Click(object sender, EventArgs e)
		{
			PersonModel personModel = DataAccess.Connection.GetPersonByID(currentPersonID);
			AddressModel addressModel = DataAccess.Connection.GetAddressByID(personModel.ID);

			currentPersonID = personModel.ID;

			firstNameTextBox.Text = personModel.FirstName;
			lastNameTextBox.Text = personModel.LastName;

			countryTextbox.Text = addressModel.Country;
			stateTextBox.Text = addressModel.State;
			cityTextbox.Text = addressModel.City;
			streetTextbox.Text = addressModel.Street;
			zIPCodeTextBox.Text = addressModel.ZIPCode.ToString();
		}
	}


}
