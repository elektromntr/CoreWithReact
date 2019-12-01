using System;

namespace BusinessLogic.Models
{
	public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class HeroSkills
	{
		public int Id { get; set; }
		public virtual Skill Skill { get; set; }
		public int SkillId { get; set; }
		public virtual Hero Hero { get; set; }
		public Guid HeroId { get; set; }
		public int Points { get; set; }
	}
}