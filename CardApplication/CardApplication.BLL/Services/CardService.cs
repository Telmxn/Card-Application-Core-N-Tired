using CardApplication.BLL.DTO;
using CardApplication.BLL.Exceptions;
using CardApplication.DataAccess.Implementation;
using CardApplication.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardApplication.BLL.Services
{
    public class CardService : ICardService
    {
        private readonly ICardAppCardRepository cardAppCardRepository;
        public CardService(ICardAppCardRepository cardRepository)
        {
            cardAppCardRepository = cardRepository;
        }
        public async Task<CardDTO> GetCardAsync(int cardId)
        {
            CardDTO cardDTO = new CardDTO() { Card = new Card() };
            var card = await cardAppCardRepository.GetCardById(cardId);
            if (card == null)
                throw new CardNotExistsException("Given Card not exists!");
            else
                if (card.Balance < 100)
                cardDTO.Information = "Your Balance is less than 100.";
            cardDTO.Card = card;

            return cardDTO;
        }
        public Task<IEnumerable<Card>> GetAllCardsAsync()
        {
            var cards = cardAppCardRepository.GetCardsAsync();

            return cards;
        }

        public async Task AddCard(Card card)
        {
            await cardAppCardRepository.AddCard(card);
            await cardAppCardRepository.SaveAsync();
        }
    }
}
