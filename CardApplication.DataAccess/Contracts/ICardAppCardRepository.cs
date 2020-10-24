using CardApplication.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication.DataAccess.Implementation
{
    public interface ICardAppCardRepository
    {
        Task AddCard(Card card);
        Task<Card> GetCardById(int id);
        Task<IEnumerable<Card>> GetCardsAsync();
        void RemoveCard(Card Card);
        Task SaveAsync();
        Task UpdateCard(int oldCardId, Card card);
    }
}
