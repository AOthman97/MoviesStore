using Microsoft.EntityFrameworkCore;
using MoviesStore.Models;

namespace MoviesStore.Data
{
    public class MovieStoreDBContext : DbContext
    {
        public MovieStoreDBContext()
        {

        }

        public MovieStoreDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnectionString");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        // This is made to define the relationships between the tables and create the individual tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This is used to create a primary key for this specific model/table, It consists of the ActorId and the MovieId fields,
            // And that's because we haven't specified a key in the ActorsMovies model definition and the primary key would consist of both of them together
            modelBuilder.Entity<ActorsMovies>().HasKey(ActorModel => new
            {
                ActorModel.ActorId,
                ActorModel.MovieId
            });

            // each of these were made in order to define the foreign key relationships between this table and the Actors and Movies tables
            modelBuilder.Entity<ActorsMovies>().HasOne(m => m.Movie).WithMany(ActorMovie => ActorMovie.ActorsMovies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<ActorsMovies>().HasOne(m => m.Actor).WithMany(ActorMovie => ActorMovie.ActorsMovies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        // Each individual db set represents a table in our DB
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<ActorsMovies> ActorsMovies { get; set; }
    }
}
