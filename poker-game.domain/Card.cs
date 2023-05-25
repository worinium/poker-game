using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class Card
    {
        public virtual int CardId { get; set; }
        public virtual int HandId { get; set; }
        public virtual int PlayerId { get; set; }
        public virtual string CardRank { get; set; }
        public virtual string CardSuit { get; set; }
        // Additional card fields...
        public virtual Hand Hand { get; set; }
        public virtual Player Player { get; set; }
    }
}
