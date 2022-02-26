using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesStore.Data.Services;

namespace MoviesStore.Controllers
{
    public class ActorsController : Controller
    {
        // Inject the DBContext file in order to use it's properties
        // Update: The constructor here was replaced by implementing the one used in the IActorsInterface and it's service file
        private readonly IActorsService _service;

        // Add a constructor to the above injection
        // Update: The constructor here was replaced by implementing the one used in the IActorsInterface and it's service file
        public ActorsController(IActorsService actorsService)
        {
            _service = actorsService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var ActorsData = await _service.GetAll();

                return View(ActorsData);
            }
            catch (Exception ex)
            {
                return View("~/Shared/Error.cshtml");
            }
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
