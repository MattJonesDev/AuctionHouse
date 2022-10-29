using AuctionHouse.Domain.Common;
using System;

namespace AuctionHouse.Domain.Entities
{
    public class Bid : BaseEntity
    {
        public decimal Amount { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
