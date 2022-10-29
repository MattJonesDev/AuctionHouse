using AuctionHouse.Domain.Common;
using System;
using System.Collections.Generic;

namespace AuctionHouse.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal StartingPrice { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Bid> Bids { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
