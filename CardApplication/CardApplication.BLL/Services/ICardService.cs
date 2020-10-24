using CardApplication.BLL.DTO;
using CardApplication.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CardApplication.BLL.Services
{
    public interface ICardService
    {
        Task<CardDTO> GetCardAsync(int cardId);
        Task<IEnumerable<Card>> GetAllCardsAsync();
        Task AddCard(Card card);
    }
}