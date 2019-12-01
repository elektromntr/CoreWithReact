using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Models
{
	public class Hero
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		private IList<Skill> Skills { get; set; }
	}
}
