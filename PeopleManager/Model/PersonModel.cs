﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Model
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

		private string personDisplayInfo;
		public string PersonDisplayInfo
		{
			get { return string.Format($"{LastName} {FirstName}"); }

		}

	}
}