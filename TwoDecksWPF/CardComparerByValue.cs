﻿using System.Collections.Generic;

namespace TwoDecksWPF
{
    class CardComparerByValue : IComparer<Card>
    {
        public int Compare(Card? x, Card? y)
        {
            if (x.Suit < y.Suit) return -1;
            else if (x.Suit > y.Suit) return 1;
            else
            {
                if (x.Value < y.Value) return -1;
                else if (x.Value > y.Value) return 1;
                return 0;
            }
        }
    }
}
