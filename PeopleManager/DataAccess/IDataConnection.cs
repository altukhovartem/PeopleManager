using PeopleManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PeopleManager.DataAccess.DapperConnection;

namespace PeopleManager.DataAccess
{
	public interface IDataConnection
	{
		int InsertPerson(PersonModel model);
		void InsertAddress(PersonModel personModel, AddressModel addressModel);
		List<PersonModel> GetListOfPeople();
		List<AddressModel> GetListOfAddresses();
	}
}
