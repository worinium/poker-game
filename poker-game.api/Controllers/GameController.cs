using db_manager.lib.Abstractions;
using Microsoft.AspNetCore.Mvc;
using poker_game.domain;

namespace poker_game.api.Controllers
{
    public class GameController : Controller
    {
        private readonly IRepository<Game> _gameRepository;

        public GameController(IRepository<Game> gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            var games = _gameRepository.GetAll();
            // Process the game data...
            return View(games);
        }

        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetById(id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // Other actions...
    }

}
