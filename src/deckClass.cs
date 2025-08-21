using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackApp {
    class Deck {
        // 内部的にカードのスタックとして保持する
        private Stack<Card> Cards { get; }

        public Deck() {
            var newCards = CreateCards();
            var shuffled = Shaffle(newCards);
            Cards = new Stack<Card>(shuffled);
        }

        // デッキの先頭からカードを一枚取り出す
        public Card Pop() => Cards.Pop();

        // 新しく52枚のカードを用意する
        private IEnumerable<Card> CreateCards() {
            var suits = GetSuitValues();
            var numbers = Enumerable.Range(1, 13);
            var cards = suits.SelectMany(suit =>
                numbers.Select(no => new Card(suit, no)));
            return cards;
        }

        // トランプのマークをすべて取得する
        private IEnumerable<Suit> GetSuitValues() =>
            Enum.GetValues(typeof(Suit)).Cast<Suit>();

        // カードをシャッフルする
        private IEnumerable<Card> Shaffle(IEnumerable<Card> cards) {
            var random = new Random();
            var shaffled = cards.OrderBy(_ => random.Next());
            return shaffled;
        }
    }
}
