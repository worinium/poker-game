using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class Hand
    {
        public virtual int HandId { get; set; }
        public virtual int GameId { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime? EndTime { get; set; }
        // Additional hand fields...
        public virtual Game Game { get; set; }
    }
}
