using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Model
{
    public class PersonModel
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

		public string PersonDisplayInfo
		{
			get { return string.Format($"{ID} {LastName} {FirstName}"); }
		}

	}
}
