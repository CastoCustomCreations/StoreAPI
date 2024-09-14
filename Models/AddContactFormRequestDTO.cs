namespace StoreAPI.Models
  {
  public class AddContactFormRequestDTO
    {
    public required string Name { get; set; }
    public string? Email { get; set; }
    public required string Phone { get; set; }
    public string? Message { get; set; }
    public string? date { get; set; }
    
    }
  }
