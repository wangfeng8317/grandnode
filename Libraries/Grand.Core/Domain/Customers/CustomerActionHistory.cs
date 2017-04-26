using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Grand.Core.Domain.Customers
{
    /// <summary>
    /// Represents a customer action
    /// </summary>
    public partial class CustomerActionHistory : BaseEntity
    {
        public string CustomerActionId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreateDateUtc { get; set; }

    }
}
