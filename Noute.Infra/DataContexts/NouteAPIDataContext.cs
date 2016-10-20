using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using NouteAPI.Domain.Entities;

namespace Noute.Infra.DataContexts
{
    public class NouteAPIDataContext : DbContext
    {
        public NouteAPIDataContext(DbContextOptions<NouteAPIDataContext> options) 
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
