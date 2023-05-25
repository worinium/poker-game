using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker_game.domain
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        // Additional user fields...
    }
}
