using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedeSocialAPI.Models;

namespace RedeSocialAPI.Data
{
    public class RedeSocialAPIContext : DbContext
    {
        public RedeSocialAPIContext (DbContextOptions<RedeSocialAPIContext> options)
            : base(options)
        {
        }

        public DbSet<RedeSocialAPI.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
