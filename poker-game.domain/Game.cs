using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class Game
    {
        public virtual int GameId { get; set; }
        public virtual string GameName { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime? EndTime { get; set; }
        // Additional game fields...
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
