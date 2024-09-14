using StoreAPI.Data;
using StoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StoreAPI.Controllers
  {
  [Route("api/[controller]")]
  [ApiController]
  public class ContactFormController : ControllerBase
    {
        private readonly StoreContext dbContext;
        public ContactFormController(StoreContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
    public IActionResult GetAllContactForm()
      {
      var ContactForm =  dbContext.ContactForm.ToList();
      return Ok(ContactForm);
      }
    [HttpPost]
    public IActionResult AddContact(AddContactFormRequestDTO request)
      {
      var domainModelContact = new ContactForm
        {
          
          Name = request.Name,
          Email = request.Email,
          Phone = request.Phone,
          Message = request.Message,
          Date = request.date,  
        };
        dbContext.ContactForm.Add(domainModelContact);
        dbContext.SaveChanges();

      return Ok(domainModelContact);
      }

    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteContact(Guid id) 
      {
      var contactform = dbContext.ContactForm.Find(id);

      if (contactform is not null)
        {
        dbContext.ContactForm.Remove(contactform);
        dbContext.SaveChanges();
        
        }
      return Ok();
      }
    }
  }
