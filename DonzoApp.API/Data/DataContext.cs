using DonzoApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DonzoApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; } // will delete later
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<WorkoutType> WorkoutTypes { get; set; }
        public DbSet<Mood> Moods { get; set; }

    }
}