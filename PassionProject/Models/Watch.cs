using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PassionProject.Models
{
    public class Watch
    {
        [Key]
        public int WatchID { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Description { get; set; } = string.Empty;

        // One-to-one relationship with Reservation
        public Reservation? Reservation { get; set; }

    }
    public class WatchDTO
    {
        public int WatchID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }


}
