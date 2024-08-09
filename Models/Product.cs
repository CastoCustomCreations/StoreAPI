using System;
using System.Collections.Generic;

namespace StoreAPI.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? CatergoryId { get; set; }

    public string? Description { get; set; }

    public byte[]? ImageOne { get; set; }

    public byte[]? ImageTwo { get; set; }

    public byte[]? ImageThree { get; set; }

    public byte[]? ImageFour { get; set; }

    public byte[]? ImageFive { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UnitsOnOrder { get; set; }

    public int? UnitsReorderLevel { get; set; }

    public int? SupplierId { get; set; }

    public int? UnitsSold { get; set; }

    public decimal? UnitWeight { get; set; }

    public string? UnitDimensions { get; set; }

    public decimal? UnitCost { get; set; }
}
