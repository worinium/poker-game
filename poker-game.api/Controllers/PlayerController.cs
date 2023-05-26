using db_manager.lib.Abstractions;
using Microsoft.AspNetCore.Mvc;
using poker_game.domain;

namespace poker_game.api.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IRepository<Player> _playerRepository;

        public PlayerController(IRepository<Player> playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public IActionResult Index()
        {
            var players = _playerRepository.GetAll();
            // Process the player data...
            return View(players);
        }

        public IActionResult Details(int id)
        {
            var player = _playerRepository.GetById(id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // Other actions...
    }

}
