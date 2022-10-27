using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public DateTime Releasedate { get; set; }
        public Company Company { get; set; }
        //unshadow the foreign key prop
        public int? CompanyId { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<Director> Directors { get; set; }

    }
}
