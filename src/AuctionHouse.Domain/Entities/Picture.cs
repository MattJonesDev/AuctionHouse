using AuctionHouse.Domain.Common;
using System;

namespace AuctionHouse.Domain.Entities
{
    public class Picture : BaseEntity
    {
        public string Url { get; set; }

        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
