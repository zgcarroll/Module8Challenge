namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Destiny 2", Genre = "Shooter", Rating = 3.0 });
            games.Add(new VideoGame { Name = "Megabonk", Genre = "Action", Rating = 5.0 });
            games.Add(new VideoGame { Name = "Bopl Battle", Genre = "Fighting", Rating = 4.5 });
            games.Add(new VideoGame { Name = "Metal Gear Solid 3", Genre = "Stealth", Rating = 4.2 });
            games.Add(new VideoGame { Name = "Gex: Enter the Gecko", Genre = "Platformer", Rating = 2.0 });


            // linq query selects games with a 4.0 rating or higher
            var topRatedGames = (from game in games
                                 where game.Rating >= 4
                                 select game).ToList();



            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }

        } // end of main class

    }
}

