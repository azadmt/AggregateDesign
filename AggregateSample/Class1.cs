using System;
using System.Data.Common;

namespace AggregateSample
{
    public class Auction
    {
        public Auction(Guid id, Guid itemId, Money startingPrice, DateTime endsAt)
        {
        }

        public Guid ItemId { get; set; }
        public DateTime EndsAt { get; set; }
        public Money StartingPrice { get; set; }
        public WinningBid WinningBid { get; set; }

        public void PlaceBidFor(Guid biderId, Money bidPrice, DateTime currentTime)
        {
            if (bidPrice > WinningBid.Price)
            {
                WinningBid = new WinningBid(biderId, bidPrice, currentTime);
            }
        }
    }
}

public class Money
{
    public decimal Value { get; set; }

    public static bool operator <(Money l, Money r)
    {
        return l.Value < r.Value;
    }

    public static bool operator >(Money l, Money r)
    {
        return l.Value > r.Value;
    }

    public override bool Equals(object? obj)
    {
        return Value.Equals(((Money)obj).Value);
    }
}

public class WinningBid
{
    public Guid BiderId { get; private set; }

    public WinningBid(Guid biderId, Money price, DateTime bidTime)
    {
        BiderId = biderId;
        Price = price;
        BidTime = bidTime;
    }

    public Money Price { get; private set; }
    public DateTime BidTime { get; private set; }
}