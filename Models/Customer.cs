using System;
using System.Collections.Generic;

namespace StoreAPI.Models;

public partial class Customer
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Phone { get; set; }

    public string Email { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? LastSignIn { get; set; }
}
