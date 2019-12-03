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
		public int? currentID;
		public List<PersonModel> ListOfPeople { get; set; }
		public List<AddressModel> ListOfAddresses { get; set; }
		public InsertNewPersonForm()
		{
			InitializeComponent();
			FetchData();
			currentID = 0;
		}

		#region Buttons
		private void saveButton_Click(object sender, EventArgs e)
		{
			//TODO Validation
			PersonModel person = new PersonModel();
			AddressModel address = new AddressModel();

			person.LastName = lastNameTextBox.Text;
			person.FirstName = firstNameTextBox.Text;

			address.Country = countryTextbox.Text;
			address.State = stateTextBox.Text;
			address.City = cityTextbox.Text;
			address.Street = streetTextbox.Text;
			address.ZIPCode = zIPCodeTextBox.Text;

			currentID = DataAccess.Connection.InsertPerson(person);
			DataAccess.Connection.InsertAddress(person, address);
			MessageBox.Show("A new record has been added");
			FetchData();
			//TODO sign of successful operation
		}
		private void nextPersonButton_Click(object sender, EventArgs e)
		{
			currentID++;

			if (currentID == ListOfPeople.Select(x=>x.ID).Max()-1)
			{
				currentID = 0;
			}

			PersonModel personModel = ListOfPeople.Where(x => x.ID >= currentID).FirstOrDefault();
			AddressModel addressModel = ListOfAddresses.Where(x => x.PersonId == personModel?.ID).FirstOrDefault();

			currentID = personModel?.ID ?? 0;

			AssignValuesToPersonFields(personModel);
			AssignValuesToAddressFields(addressModel);
		}
		private void previousPersonButton_Click(object sender, EventArgs e)
		{
			currentID--;

			if(currentID == -1)
			{
				currentID = ListOfPeople.Select(x=>x.ID).Max();
			}

			PersonModel personModel = ListOfPeople.Where(x => x.ID <= currentID).LastOrDefault();
			AddressModel addressModel = ListOfAddresses.Where(x => x.PersonId == personModel?.ID).FirstOrDefault();

			currentID = personModel?.ID ?? 0;

			AssignValuesToPersonFields(personModel);
			AssignValuesToAddressFields(addressModel);
		}
		private void InsertButton_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void cancelButton_Click(object sender, EventArgs e)
		{
			ClearForm();
		}
		private void deleteButton_Click(object sender, EventArgs e)
		{
			if(AskUserToDeleteRecord())
			{
				DataAccess.Connection.DeletePerson(currentID);
				ResetAllTextBoxes(this.Controls);
				currentID = 0;
				FetchData();
			}
		}

		#endregion

		#region Helpers
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
		private void AssignValuesToPersonFields(PersonModel personModel)
		{
			firstNameTextBox.Text = personModel?.FirstName;
			lastNameTextBox.Text = personModel?.LastName;
		}
		private void AssignValuesToAddressFields(AddressModel addressModel)
		{
			countryTextbox.Text = addressModel?.Country;
			stateTextBox.Text = addressModel?.State;
			cityTextbox.Text = addressModel?.City;
			streetTextbox.Text = addressModel?.Street;
			zIPCodeTextBox.Text = addressModel?.ZIPCode;
		}
		private void FetchData()
		{
			ListOfPeople = DataAccess.Connection.GetListOfPeople();
			ListOfAddresses = DataAccess.Connection.GetListOfAddresses();
		}
		private void ClearForm()
		{
			bool textBoxIsNotEmpty = CheckTextBoxesForData(Controls);

			if (textBoxIsNotEmpty)
			{
				DialogResult result = MessageBox.Show("Are you sure you want to discard you changes?", "Discard", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
				{
					ResetAllTextBoxes(this.Controls);
					currentID = 0;
				}
			}
		}
		private bool AskUserToDeleteRecord()
		{
			DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.OKCancel);
			if(result == DialogResult.OK)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion

		// todo - rewrite it as extension method
	}
}


