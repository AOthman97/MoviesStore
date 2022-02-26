using Microsoft.EntityFrameworkCore;
using MoviesStore.Models;

namespace MoviesStore.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly MovieStoreDBContext _dbContext;

        public ActorsService(MovieStoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddActor(Actor actor)
        {
            throw new NotImplementedException();
        }

        public bool DeleteActor(int ActorId)
        {
            throw new NotImplementedException();
        }

        public Actor GetActor(int ActorId)
        {
            throw new NotImplementedException();
        }

        public Actor UpdateActor(int ActorId, Actor actor)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<Actor>> IActorsService.GetAll()
        {
            var Result = await _dbContext.Actors.OrderBy(Actor => Actor.FullName).ToListAsync();
            return Result;
        }
    }
}
