using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public class Team
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Nickname { get; set; }

		// TODO: 7) Currently we can't see a list of players in a team on the Team details screen. Let's add them.
		public ICollection<Player> Players { get; set; }

	}
}
