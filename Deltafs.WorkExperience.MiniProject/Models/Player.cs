using System.ComponentModel.DataAnnotations;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public class Player
	{
		[Key]
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Number { get; set; }

		public Team Team { get; set; }

	}
}