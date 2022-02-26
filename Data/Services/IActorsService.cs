using MoviesStore.Models;

namespace MoviesStore.Data.Services
{
    public interface IActorsService
    {
        public Task<IEnumerable<Actor>> GetAll();
        Actor GetActor(int ActorId);
        bool AddActor(Actor actor);
        Actor UpdateActor(int ActorId, Actor actor);
        bool DeleteActor(int ActorId);
    }
}
