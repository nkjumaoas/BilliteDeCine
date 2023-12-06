using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbsys
{
    public class MovieDetails
    {
        public int MovieNo { get; set; }
        public string MovieTitle { get; set; }
        public decimal? Price { get; set; }
        public DateTime? ShowingDate { get; set; }
    }
}
