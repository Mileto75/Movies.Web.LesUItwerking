using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities
{
    public class Director : BasePersonEntity
    {
        public ICollection<Movie> Movies { get; set; }
    }
}
