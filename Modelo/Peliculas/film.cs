using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Peliculas
{
    public class film
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int relase_year { get; set; }
        public string rental_duration { get; set; }
        public int length { get; set; }
        public int replacement_cost { get; set; }
        public string rating { get; set; }
        public DateTime last_update { get; set; }
        public string special_fectures { get; set; }
        public string fulltext { get; set; }
        //relacion languaje
        public int CurrentMovie { get; set; }
        public language language { get; set; }
        //relacion inventory
        public ICollection<inventory> inventories { get; set; }

    }
}
