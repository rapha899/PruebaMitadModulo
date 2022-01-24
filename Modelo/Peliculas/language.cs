using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Peliculas
{
    public class language
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime last_update { get; set; }

        public ICollection<film> films { get; set;}
    }
}
