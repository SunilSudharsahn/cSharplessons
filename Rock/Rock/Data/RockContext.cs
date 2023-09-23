using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Rock.Data
{
    public class RockContext : DbContext
    {
        public RockContext (DbContextOptions<RockContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Author { get; set; } = default!;

        internal void Add(object author)
        {
            throw new NotImplementedException();
        }
    }
}
