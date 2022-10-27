using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Core.Entities
{
    public class BasePersonEntity : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
