using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class Player
    {
        public virtual int PlayerId { get; set; }
        public virtual int HandId { get; set; }
        public virtual int UserId { get; set; }
        // Additional player fields...
        public virtual Hand Hand { get; set; }
        public virtual User User { get; set; }
    }
}
