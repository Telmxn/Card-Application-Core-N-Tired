using CardApplication.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication.DataAccess.Implementation
{
    public class CardAppCardRepository : ICardAppCardRepository
    {
        private readonly CardApplicationDbContext _cardApplicationDbContext;

        public CardAppCardRepository(CardApplicationDbContext cardApplicationDbContext)
        {
            _cardApplicationDbContext = cardApplicationDbContext;
        }

        public async Task AddCard(Card card)
        {
            await _cardApplicationDbContext.Cards.AddAsync(card);
        }

        public async Task<Card> GetCardById(int id)
        {
            return await _cardApplicationDbContext.Cards.FindAsync(id);
        }

        public async Task<IEnumerable<Card>> GetCardsAsync()
        {
            return await _cardApplicationDbContext.Cards.ToListAsync();
        }

        public void RemoveCard(Card card)
        {
            _cardApplicationDbContext.Cards.Remove(card);
        }

        public async Task SaveAsync()
        {
            await _cardApplicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateCard(int oldCardId, Card card)
        {
            var oldCard = await _cardApplicationDbContext.Cards.FindAsync(oldCardId);
            oldCard.CardNumber = card.CardNumber;
            oldCard.CVC = card.CVC;
            oldCard.ExpDate = card.ExpDate;
            oldCard.Holder = card.Holder;
            await _cardApplicationDbContext.SaveChangesAsync();
        }
    }
}
