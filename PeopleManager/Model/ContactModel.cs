using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Model
{
    class AddressModel
    {
        public int PersonId { get; set; }
        public string Country { get; set; }
		public string State { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public int ZIPCode { get; set; }
										   //public string Phone { get; set; }
										   //      public string Email { get; set; }
	}
}
