using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Peliculas
{
    public class inventory
    {
        public int id{ get; set; }
        public DateTime last_update { get; set; }

        public int CurrentFilmid { get; set; }
        public  film film { get; set; }
    }
}
