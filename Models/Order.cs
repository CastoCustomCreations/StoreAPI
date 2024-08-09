using System;
using System.Collections.Generic;

namespace StoreAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public string CustomerId1 { get; set; } = null!;
}
