namespace StoreAPI.Models
  {
  public class AddProductDTO
    {   

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public string? ImageOne { get; set; }

    public string? ImageTwo { get; set; }

    public string? ImageThree { get; set; }

    public string? ImageFour { get; set; }

    public string? ImageFive { get; set; }

    public int? UnitsInStock { get; set; }

    public int? UnitsOnOrder { get; set; }

    public int? UnitsReorderLevel { get; set; }

    public int? SupplierId { get; set; }

    public int? UnitsSold { get; set; }

    public decimal? UnitWeight { get; set; }

    public string? UnitDimensions { get; set; }

    public decimal? UnitCost { get; set; }
    

    }
  }
