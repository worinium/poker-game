using db_manager.lib.Abstractions;
using Microsoft.AspNetCore.Mvc;
using poker_game.domain;

namespace poker_game.api.Controllers
{
    public class BetController : Controller
    {
        private readonly IRepository<Bet> _betRepository;

        public BetController(IRepository<Bet> betRepository)
        {
            _betRepository = betRepository;
        }

        public IActionResult Index()
        {
            var users = _betRepository.GetAll();
            // Process the user data...
            return View(users);
        }

        public IActionResult Details(int id)
        {
            var bet = _betRepository.GetById(id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bet bet)
        {
            if (ModelState.IsValid)
            {
                _betRepository.Add(bet);
                return RedirectToAction("Index");
            }

            return View(bet);
        }

        public IActionResult Edit(int id)
        {
            var bet = _betRepository.GetById(id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        [HttpPost]
        public IActionResult Edit(int id, Bet bet)
        {
            if (id != bet.BetId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _betRepository.Update(bet);
                return RedirectToAction("Index");
            }

            return View(bet);
        }

        public IActionResult Delete(int id)
        {
            var bet = _betRepository.GetById(id);
            if (bet == null)
            {
                return NotFound();
            }

            return View(bet);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var bet = _betRepository.GetById(id);
            if (bet == null)
            {
                return NotFound();
            }

            _betRepository.Delete(bet);
            return RedirectToAction("Index");
        }


    }
}
