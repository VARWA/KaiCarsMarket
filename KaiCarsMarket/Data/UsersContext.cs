using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaiCarsMarket.Models;

namespace KaiCarsMarket.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext (DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<KaiCarsMarket.Models.Users> Users { get; set; } = default!;
        public DbSet<KaiCarsMarket.Models.Cars> Cars { get; set; } = default!;
    }
}
