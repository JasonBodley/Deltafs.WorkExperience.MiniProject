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
			var liverpool = new Team
			{
				Name = "Liverpool",
				Nickname = "The Reds"
			};
			var man_city = new Team
			{
				Name = "Manchester City",
				Nickname = "Man City"
			};
			var rui = new Player
			{
				FirstName = "Rui",
				LastName = "Patrício",
				Number = 11,
				Position = "Goalkeeper",
				Team = wolves
			};
			var jonny = new Player
			{
				FirstName = "Jonny",
				LastName = "Castro Otto",
				Number = 19,
				Position = "Full Back",
				Team = wolves
			};
			var boly = new Player
			{
				FirstName = "Willy",
				LastName = "Boly",
				Number = 15,
				Position = "Centre Back",
				Team = wolves
			};
			var coady = new Player
			{
				FirstName = "Conor",
				LastName = "Coady",
				Number = 16,
				Position = "Centre Back",
				Team = wolves
			};
			var saiss = new Player
			{
				FirstName = "Romain",
				LastName = "Saïss",
				Number = 27,
				Position = "Centre Back",
				Team = wolves
			};
			var doherty = new Player
			{
				FirstName = "Matt",
				LastName = "Doherty",
				Number = 2,
				Position = "Full Back",
				Team = wolves
			};
			var moutinho = new Player
			{
				FirstName = "João",
				LastName = "Moutinho",
				Number = 28,
				Position = "Midfielder",
				Team = wolves
			};
			var neves = new Player
			{
				FirstName = "Rúben",
				LastName = "Neves",
				Number = 8,
				Position = "Midfielder",
				Team = wolves
			};
			var jota = new Player
			{
				FirstName = "Diogo",
				LastName = "Jota",
				Number = 18,
				Position = "Left Winger",
				Team = wolves
			};
			var jimenez = new Player
			{
				FirstName = "Raúl",
				LastName = "Jiménez",
				Number = 9,
				Position = "Striker",
				Team = wolves
			};
			var traore = new Player
			{
				FirstName = "Adama",
				LastName = "Traoré",
				Number = 37,
				Position = "Right Winger",
				Team = wolves
			};
			var alisson = new Player
			{
				FirstName = "Alisson",
				LastName = "Becker",
				Number = 1,
				Position = "Goalkeeper",
				Team = liverpool
			};
			var robertson = new Player
			{
				FirstName = "Andrew",
				LastName = "Robertson",
				Number = 26,
				Position = "Full Back",
				Team = liverpool
			};
			var matip = new Player
			{
				FirstName = " Joel",
				LastName = "Matip",
				Number = 32,
				Position = "Centre Back",
				Team = liverpool
			};
			var van_dijk = new Player
			{
				FirstName = "Virgil",
				LastName = "van Dijk",
				Number = 4,
				Position = "Centre Back",
				Team = liverpool
			};
			var trent = new Player
			{
				FirstName = "Trent",
				LastName = "Alexander-Arnold",
				Number = 66,
				Position = "Full Back",
				Team = liverpool
			};
			var fab = new Player
			{
				FirstName = "Fábio",
				LastName = "Henrique Tavares",
				Number = 3,
				Position = "Midfielder",
				Team = liverpool
			};
			var gini = new Player
			{
				FirstName = "Georginio",
				LastName = "Wijnaldum",
				Number = 5,
				Position = "Midfielder",
				Team = liverpool
			};
			var hendo = new Player
			{
				FirstName = "Jordan",
				LastName = "Henderson",
				Number = 14,
				Position = "Midfielder",
				Team = liverpool
			};
			var mane = new Player
			{
				FirstName = "Sadio",
				LastName = "Mané",
				Number = 10,
				Position = "Left Winger",
				Team = liverpool
			};
			var bobby = new Player
			{
				FirstName = "Roberto",
				LastName = "Firmino",
				Number = 9,
				Position = "Centre Forward",
				Team = liverpool
			};
			var salah = new Player
			{
				FirstName = "Mohamed",
				LastName = "Salah",
				Number = 11,
				Position = "Right Winger",
				Team = liverpool
			};
			var ederson = new Player
			{
				FirstName = "Ederson",
				LastName = "Moraes",
				Number = 31,
				Position = "Goalkeeper",
				Team = man_city
			};
			var mendy = new Player
			{
				FirstName = "Benjamin",
				LastName = "Mendy",
				Number = 22,
				Position = "Full Back",
				Team = man_city
			};
			var fernandinho = new Player
			{
				FirstName = "Fernando",
				LastName = "Luiz Roza",
				Number = 25,
				Position = "Centre Back",
				Team = man_city
			};
			var laporte = new Player
			{
				FirstName = "Aymeric",
				LastName = "Laporte",
				Number = 14,
				Position = "Centre Back",
				Team = man_city
			};
			var kyle = new Player
			{
				FirstName = "Kyle",
				LastName = "Walker",
				Number = 2,
				Position = "Full Back",
				Team = man_city
			};
			var kevin = new Player
			{
				FirstName = "Kevin",
				LastName = "de Bruyne",
				Number = 17,
				Position = "Midfielder",
				Team = man_city
			};
			var silva = new Player
			{
				FirstName = "Bernardo",
				LastName = "Silva",
				Number = 20,
				Position = "Midfielder",
				Team = man_city
			};
			var rodri = new Player
			{
				FirstName = "Rodrigo",
				LastName = "Hernández Cascante",
				Number = 16,
				Position = "Midfielder",
				Team = man_city
			};
			var jesus = new Player
			{
				FirstName = "Gabriel",
				LastName = "Jesus",
				Number = 9,
				Position = "Left Winger",
				Team = man_city
			};
			var sergio = new Player
			{
				FirstName = "Sergio",
				LastName = "Agüero",
				Number = 10,
				Position = "Striker",
				Team = man_city
			};
			var riyad = new Player
			{
				FirstName = "Riyad",
				LastName = "Mahrez",
				Number = 26,
				Position = "Right Winger",
				Team = man_city
			};

			context.Teams.Add(wolves);
			context.Teams.Add(liverpool);
			context.Teams.Add(man_city);
			context.Players.Add(rui);
			context.Players.Add(jonny);
			context.Players.Add(boly);
			context.Players.Add(coady);
			context.Players.Add(saiss);
			context.Players.Add(doherty);
			context.Players.Add(moutinho);
			context.Players.Add(neves);
			context.Players.Add(jota);
			context.Players.Add(jimenez);
			context.Players.Add(traore);
			context.Players.Add(alisson);
			context.Players.Add(robertson);
			context.Players.Add(matip);
			context.Players.Add(van_dijk);
			context.Players.Add(trent);
			context.Players.Add(fab);
			context.Players.Add(gini);
			context.Players.Add(hendo);
			context.Players.Add(mane);
			context.Players.Add(bobby);
			context.Players.Add(salah);
			context.Players.Add(ederson);
			context.Players.Add(mendy);
			context.Players.Add(fernandinho);
			context.Players.Add(laporte);
			context.Players.Add(kyle);
			context.Players.Add(kevin);
			context.Players.Add(silva);
			context.Players.Add(rodri);
			context.Players.Add(jesus);
			context.Players.Add(sergio);
			context.Players.Add(riyad);
			// Save the changes to the database
			context.SaveChanges();
		}
	}
}