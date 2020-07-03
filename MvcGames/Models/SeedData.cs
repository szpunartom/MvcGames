using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGames.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGames.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcGamesContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "The Last of Us: Part II",
                        Platforms = "Playstation 4",
                        ReleaseDate = DateTime.Parse("2020-6-19"),
                        Genre = "Adventure",
                        Developer = "Naughty Dog",
                        Publisher = "Sony Interactive Entertainment"
                    },

                    new Game
                    {
                        Title = "VALORANT",
                        Platforms = "PC",
                        ReleaseDate = DateTime.Parse("2020-6-2"),
                        Genre = "Shooter",
                        Developer = "Riot Games",
                        Publisher = "Riot Games"
                    },

                    new Game
                    {
                        Title = "Tainted Grail",
                        Platforms = "PC",
                        ReleaseDate = DateTime.Parse("2020-6-18"),
                        Genre = "RPG",
                        Developer = "Awaken Realms",
                        Publisher = "Awaken Realms"
                    },

                    new Game
                    {
                        Title = "Pokémon Sword",
                        Platforms = "Nintendo Switch",
                        ReleaseDate = DateTime.Parse("2019-11-15"),
                        Genre = "Adventure",
                        Developer = "Game Freak",
                        Publisher = "Nintendo"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
