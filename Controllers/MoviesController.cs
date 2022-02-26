using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesStore.Data;

namespace MoviesStore.Controllers
{
    public class MoviesController : Controller
    {
        // Inject the DBContext file in order to use it's properties
        private readonly MovieStoreDBContext _context;

        // Add a constructor to the above injection
        public MoviesController(MovieStoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                // The include() method is used to get properties/data from other models whilst getting the base model's data also
                var MoviesData = await _context.Movies.Include(Cinema => Cinema.Cinema).OrderBy(Movie => Movie.EndDate).ToListAsync();

                return View(MoviesData);
            }
            catch (Exception ex)
            {
                return View("~/Shared/Error.cshtml");
            }
        }
    }
}
