using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Table
    {
        public int Number { get; set; }
        public int Seating { get; set; }
        public bool Occupied { get; set; } = false;
        public DateTime Reserved { get; set; }
        public DateTime Freed { get; set; }

        public Table(int number, int seating, bool occupied)
        {
            Number = number;
            Seating = seating;
            Occupied = occupied;
        }
    }
}
