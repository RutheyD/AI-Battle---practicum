using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Winner
    {
        //public Guid ID { get; set; }
        //public Challenge Challenge { get; set; }
        //public Image Image { get; set; }
        //public User User { get; set; }
        //public DateTime WinDate { get; set; }
        public int Id { get; set; }

        public int ChallengeId { get; set; } // קשר לאתגר
        public Challenge Challenge { get; set; }

        public int ImageId { get; set; } // קשר לתמונה המנצחת
        public Image Image { get; set; }
        public int UserId { get; set; } // מזהה המשתמש שזכה
        public User User { get; set; }

        public DateTime WinDate { get; set; } // תאריך הזכייה
    }
}
