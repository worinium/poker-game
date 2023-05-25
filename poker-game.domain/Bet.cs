using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class Bet
    {
        public virtual int BetId { get; set; }
        public virtual int HandId { get; set; }
        public virtual int PlayerId { get; set; }
        public virtual decimal BetAmount { get; set; }
        // Additional bet fields...
        public virtual Hand Hand { get; set; }
        public virtual Player Player { get; set; }
    }
}
