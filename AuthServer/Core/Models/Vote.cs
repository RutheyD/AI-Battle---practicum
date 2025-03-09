using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vote
    {
        //public Guid ID { get; set; }
        //public User User { get; set; }
        //public Image Image{ get; set; }

        //public DateTime VoteDate { get; set; }
        public int Id { get; set; }

        public int UserId { get; set; } // קשר למשתמש שהצביע
        public User User { get; set; }

        public int ImageId { get; set; } // קשר לתמונה שהצביעו עליה
        public Image Image { get; set; }

        public DateTime VoteDate { get; set; } // תאריך הצבעה
    }
}
