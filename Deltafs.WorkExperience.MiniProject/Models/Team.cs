using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<Player> Players { get; set; }

	}
}
