using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TicketSystemForTrains
{

    [Table("Route")]
    public class Route
    {
        [PrimaryKey, AutoIncrement][Column("id")] public int Id { get; set; }
        [Column("fStation")] public string fStation { get; set; }
        [Column("lStation")] public string lStation { get; set; }
        [Column("fClassPrice")] public int fClassPrice { get; set; }
        [Column("sClassPrice")] public int sClassPrice { get; set; }
        [Column("type")] public int type { get; set; }
        [Column("numStops")] public int numStops { get; set; } 
    }

}
