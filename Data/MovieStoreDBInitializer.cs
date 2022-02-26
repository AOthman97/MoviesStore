using MoviesStore.Models;

namespace MoviesStore.Data
{
    public class MovieStoreDBInitializer
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using var ServiceScope = applicationBuilder.ApplicationServices.CreateScope();
            //using (var context = ServiceScope.ServiceProvider.GetRequiredService<MovieStoreDBContext>())
            //{
            //    if (context.Database.EnsureCreated())
            //    {
            //        var a = context.Database.ProviderName;
            //    }
            //}

            var Context = ServiceScope.ServiceProvider.GetService<MovieStoreDBContext>();

            Context.Database.EnsureCreated();

            // Cinemas data
            if (!Context.Cinemas.Any())
            {
                Context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "First Cinema",
                            CinemaDescription = "The first cinema",
                            CinemaImagePath = "https://images.unsplash.com/photo-1536440136628-849c177e76a1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=725&q=80"
                        },
                        new Cinema()
                        {
                            CinemaName = "Second Cinema",
                            CinemaDescription = "The Second cinema",
                            CinemaImagePath = "https://images.unsplash.com/photo-1598204865701-a5a6e15ece69?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Cinema()
                        {
                            CinemaName = "Third Cinema",
                            CinemaDescription = "The Third cinema",
                            CinemaImagePath = "https://images.unsplash.com/photo-1581157485493-f320295061c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Cinema()
                        {
                            CinemaName = "Fourth Cinema",
                            CinemaDescription = "The Fourth cinema",
                            CinemaImagePath = "https://images.unsplash.com/photo-1644916081706-e98b1fadc319?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
                        }
                    });
                Context.SaveChanges();
            }
            // Producers data
            if (!Context.Producers.Any())
            {
                Context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            ProducerName = "James Clear",
                            Bio = "World Director",
                            ProfileImagePath = "https://images.unsplash.com/photo-1536440136628-849c177e76a1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=725&q=80"
                        },
                        new Producer()
                        {
                            ProducerName = "May Sung",
                            Bio = "Chinese Director",
                            ProfileImagePath = "https://images.unsplash.com/photo-1598204865701-a5a6e15ece69?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Producer()
                        {
                            ProducerName = "Third Cinema",
                            Bio = "The Third cinema",
                            ProfileImagePath = "https://images.unsplash.com/photo-1581157485493-f320295061c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Producer()
                        {
                            ProducerName = "Fourth Cinema",
                            Bio = "The Fourth cinema",
                            ProfileImagePath = "https://images.unsplash.com/photo-1644916081706-e98b1fadc319?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
                        }
                    });
                Context.SaveChanges();
            }
            // Actors data
            if (!Context.Actors.Any())
            {
                Context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "James Clear",
                            Bio = "World Director",
                            ProfileImagePath = "https://images.unsplash.com/photo-1536440136628-849c177e76a1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=725&q=80"
                        },
                        new Actor()
                        {
                            FullName = "May Sung",
                            Bio = "Chinese Director",
                            ProfileImagePath = "https://images.unsplash.com/photo-1598204865701-a5a6e15ece69?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Actor()
                        {
                            FullName = "Third Cinema",
                            Bio = "The Third cinema",
                            ProfileImagePath = "https://images.unsplash.com/photo-1581157485493-f320295061c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80"
                        },
                        new Actor()
                        {
                            FullName = "Fourth Cinema",
                            Bio = "The Fourth cinema",
                            ProfileImagePath = "https://images.unsplash.com/photo-1644916081706-e98b1fadc319?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80"
                        }
                    });
                Context.SaveChanges();
            }
            // Movies data
            if (!Context.Movies.Any())
            {
                Context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            MovieName = "James Clear",
                            MovieDescription = "World Director",
                            MovieImagePath = "https://images.unsplash.com/photo-1536440136628-849c177e76a1?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=725&q=80",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(4),
                            Price = 45,
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 2,
                            ProducerId = 1
                        },
                        new Movie()
                        {
                            MovieName = "May Sung",
                            MovieDescription = "Chinese Director",
                            MovieImagePath = "https://images.unsplash.com/photo-1598204865701-a5a6e15ece69?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80",
                            StartDate = DateTime.Now.AddDays(1),
                            EndDate = DateTime.Now.AddDays(3),
                            Price = 11,
                            MovieCategory = MovieCategory.Thriller,
                            CinemaId = 4,
                            ProducerId = 2
                        },
                        new Movie()
                        {
                            MovieName = "Third Cinema",
                            MovieDescription = "The Third cinema",
                            MovieImagePath = "https://images.unsplash.com/photo-1581157485493-f320295061c8?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=387&q=80",
                            StartDate = DateTime.Now.AddDays(10),
                            EndDate = DateTime.Now.AddDays(30),
                            Price = 49,
                            MovieCategory = MovieCategory.ScienceFiction,
                            CinemaId = 3,
                            ProducerId = 4
                        },
                        new Movie()
                        {
                            MovieName = "Fourth Cinema",
                            MovieDescription = "The Fourth cinema",
                            MovieImagePath = "https://images.unsplash.com/photo-1644916081706-e98b1fadc319?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=870&q=80",
                            StartDate = DateTime.Now.AddDays(2),
                            EndDate = DateTime.Now.AddDays(20),
                            Price = 28,
                            MovieCategory = MovieCategory.Thriller,
                            CinemaId = 1,
                            ProducerId = 2
                        }
                    });
                Context.SaveChanges();
            }
            // Actors & Movies data
            if (!Context.ActorsMovies.Any())
            {
                Context.ActorsMovies.AddRange(new List<ActorsMovies>
                    {
                        new ActorsMovies()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                        new ActorsMovies()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new ActorsMovies()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new ActorsMovies()
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                        new ActorsMovies()
                        {
                            ActorId = 4,
                            MovieId = 1
                        },
                        new ActorsMovies()
                        {
                            ActorId = 3,
                            MovieId = 3
                        }
                    });
                Context.SaveChanges();
            }
        }
    }
}
