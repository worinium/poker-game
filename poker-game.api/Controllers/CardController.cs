using db_manager.lib.Abstractions;
using Microsoft.AspNetCore.Mvc;
using poker_game.domain;

namespace poker_game.api.Controllers
{
    public class CardController : Controller
    {
        private readonly IRepository<Card> _cardRepository;

        public CardController(IRepository<Card> cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public IActionResult Index()
        {
            var cards = _cardRepository.GetAll();
            // Process the card data...
            return View(cards);
        }

        public IActionResult Details(int id)
        {
            var card = _cardRepository.GetById(id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // Other actions...
    }

}
