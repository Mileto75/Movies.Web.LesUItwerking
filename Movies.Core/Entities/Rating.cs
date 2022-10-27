using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities
{
    public class Rating : BaseEntity
    {
        public int Score { get; set; }
        public string Review { get; set; }
        public User User { get; set; }
        //for set null cascade foreign key nullable
        public int? UserId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
    }
}
