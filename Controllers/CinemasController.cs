using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesStore.Data;

namespace MoviesStore.Controllers
{
    public class CinemasController : Controller
    {
        // Inject the DBContext file in order to use it's properties
        private readonly MovieStoreDBContext _context;

        // Add a constructor to the above injection
        public CinemasController(MovieStoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var CinemasData = await _context.Cinemas.ToListAsync();

                return View(CinemasData);
            }
            catch (Exception ex)
            {
                return View("~/Shared/Error.cshtml");
            }
        }
    }
}
