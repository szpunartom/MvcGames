using Microsoft.EntityFrameworkCore;
using MvcGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcGames.Data
{
    public class MvcGamesContext : DbContext
    {
        public MvcGamesContext(DbContextOptions<MvcGamesContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}
