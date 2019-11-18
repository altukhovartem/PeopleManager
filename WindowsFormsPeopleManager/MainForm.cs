using Dapper;
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
	public partial class MainForm : Form
	{
		private List<PersonModel> listOfPeople = new List<PersonModel>();

		public MainForm()
		{
			InitializeComponent();
			UpdatePeopleListBox();
		}

		private void UpdatePeopleListBox()
		{
			listOfPeopleListbox.DataSource = listOfPeople;
			listOfPeopleListbox.DisplayMember = "PersonDisplayInfo";
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			using (IDbConnection connection = new SqlConnection(DataAccess.ConnectionString))
			{
				DynamicParameters p = new DynamicParameters();
				p.Add("@LastName", searchTextBox.Text);
				listOfPeople = connection.Query<PersonModel>("GetPersonByLastName", p, commandType: CommandType.StoredProcedure) as List<PersonModel>;
			}
			UpdatePeopleListBox();
		}

		private void RedirectToAddNewPersonFormButton_Click(object sender, EventArgs e)
		{
			InsertNewPersonForm form = new InsertNewPersonForm();
			form.Show();
		}

		private void OpenRecordButton_Click(object sender, EventArgs e)
		{
			PersonModel person = listOfPeopleListbox.SelectedItem as PersonModel;

			if(person == null)
			{
				return;
			}
		}
	}
}
