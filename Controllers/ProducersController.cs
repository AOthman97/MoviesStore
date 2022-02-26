using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesStore.Data;

namespace MoviesStore.Controllers
{
    public class ProducersController : Controller
    {
        // Inject the DBContext file in order to use it's properties
        private readonly MovieStoreDBContext _context;

        // Add a constructor to the above injection
        public ProducersController(MovieStoreDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var ProducersData = await _context.Producers.ToListAsync();

                return View(ProducersData);
            }
            catch (Exception ex)
            {
                return View("~/Shared/Error.cshtml");
            }
        }
    }
}
