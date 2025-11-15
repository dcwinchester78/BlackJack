using System.Collections.Generic;

namespace BlackJackEngine
{
    public class Hand
    {
        private readonly List<Card> _cards = new List<Card>();

        public IEnumerable<Card> Cards => _cards;

        public Hand()
        {
        }

        public Hand(IEnumerable<Card> initialCards)
        {
            _cards.AddRange(initialCards);
        }

        public void AddCard(Card card)
        {
            _cards.Add(card);
        }
    }
}
