using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardApplication.BLL.Services;
using CardApplication.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace CardApplication.UI.Controllers
{
    public class CardController : Controller
    {
        private readonly ICardService _cardService;
        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }
        public async Task<IActionResult> Index()
        {
            var cards = await _cardService.GetAllCardsAsync();
            return View(cards);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(Card card)
        {
            if (ModelState.IsValid)
            {
                await _cardService.AddCard(card);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
