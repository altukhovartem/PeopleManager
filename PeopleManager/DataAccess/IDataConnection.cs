using PeopleManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.DataAccess
{
	public interface IDataConnection
	{
		int InsertPerson(PersonModel model);
		void InsertAddress(PersonModel personModel, AddressModel addressModel);
		PersonModel GetPersonByID(int ID);
		AddressModel GetAddressByID(int ID);
	}
}
