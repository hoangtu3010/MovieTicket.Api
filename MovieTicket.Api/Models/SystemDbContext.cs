using Microsoft.EntityFrameworkCore;

namespace MovieTicket.Api.Models
{
    public class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
        {

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRoleMapping> RoleMappings { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Crew> Crewers { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<ComboFood> ComboFoods { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
