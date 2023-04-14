﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Threading;

namespace TwoDecksWPF
{
    class Deck : ObservableCollection<Card>
    {
        private static Random random= new Random();
        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            Clear();            
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    Add(new Card((Values)value, (Suits)suit));
                }
            }
        }
        public Card Deal(int index)
        {
            Card card = base[index];
            RemoveAt(index);
            return card;
        }
        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
        }
        public void Sort()
        {
            List<Card> sortedCards = new List<Card>(this);
            Clear();
            sortedCards.Sort(new CardComparerByValue());
            foreach (Card card in sortedCards)
            {
                Add(card);
            }
        }
    }
}
