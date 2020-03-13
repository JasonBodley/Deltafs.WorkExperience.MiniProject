using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public class Player
	{
		[Key]
		public int Id { get; set; }

		// TODO: 6a) First Name should be mandatory
		[DisplayName("First Name")]
		public string FirstName { get; set; }

		// TODO: 2) This is showing up as the variable name 'LastName' on the web site, change it to make sure it's showing 'Last Name' hint: 'FirstName' is working fine
		// TODO: 6b) Last Name should be mandatory
		[DisplayName("Last Name")]
		public string LastName { get; set; }

		public int Number { get; set; }

		// TODO: 3) This is not showing up on any of the List, Create or Details screens. Add it to those screens and check the values are showing correctly
		[DisplayName("Position")]
		public string Position { get; set; }

		// TODO: 5) Iry and create a player without assigning a Team ... fix it by making this [Required]
		[ForeignKey(nameof(Team)), DisplayName(nameof(Team))]
		public int TeamId { get; set; }

		// TODO: 4) There is no reference to which Player a team in on the List / Details screens. Add it to those screens and check the values are showing correctly.
		public Team Team { get; set; }

	}
}