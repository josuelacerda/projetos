using System;

namespace Dublin.Domain.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public int PlaceId { get; set; }
        public int PersonId { get; set; }
        public DateTime MoveIn { get; set; }
        public DateTime MoveOut { get; set; }
    }
}
