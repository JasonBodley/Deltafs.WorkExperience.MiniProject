using System.Linq;
using System.Threading.Tasks;

namespace Deltafs.WorkExperience.MiniProject.Models
{
	public static class DbInitializer
	{
		public static async Task Initialize(LeagueContext context)
		{
			await context.Database.EnsureDeletedAsync();
			await context.Database.EnsureCreatedAsync();

			// TODO: 1) Add all of your teams & players here. Use the below as an example.
			// Pick 3 of your favourite teams from the Premier League
			// Pick 11 of your favourite players in that team and make sure they are added to their teams
			// To verify this works you can run the application (F5) and navigate to the 'Teams' & 'Players' screens
			var wolves = new Team
			{
				Name = "Wolverhampton Wanderers",
				Nickname = "Wolves"
			};

			var player = new Player
			{
				FirstName = "Rui",
				LastName = "Patrício",
				Number = 11,
				Position = "Goalkeeper",
				Team = wolves
			};

			context.Teams.Add(wolves);
			context.Players.Add(player);

			// Save the changes to the database
			context.SaveChanges();
		}
	}
}