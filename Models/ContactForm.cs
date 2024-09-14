using System;
using System.Collections.Generic;

namespace StoreAPI.Models;

public partial class ContactForm
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string? Email { get; set; } 

    public string? Phone { get; set; }    

    public string? Message { get; set; }

    public string? Date { get; set; }

    
}
