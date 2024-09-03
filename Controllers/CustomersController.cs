using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreAPI.Data;
using StoreAPI.Models;

namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly StoreContext _context;

        public CustomersController(StoreContext context)
        {
            this._context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public IActionResult GetCustomers()
        {
          var customer = _context.Customers.ToList();
          return Ok(customer);
        }   

        // GET: api/Customers/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.Find(id);

            if (customer is null)
            {
                return NotFound();
            }          

            return Ok(customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754



        
        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
    public IActionResult AddEmployee(AddCustomerDTO addCustomerDTO)
      {
      var customerEntity = new Customer()
        {
        FirstName = addCustomerDTO.FirstName,
        LastName = addCustomerDTO.LastName,
        Address1 = addCustomerDTO.Address1,
        Address2 = addCustomerDTO.Address2,
        City = addCustomerDTO.City,
        State = addCustomerDTO.State,
        Zipcode = addCustomerDTO.Zipcode,
        Phone = addCustomerDTO.Phone,
        Email = addCustomerDTO.Email,
        UserName = addCustomerDTO.UserName,
        Password = addCustomerDTO.Password,
        
        };
      _context.Customers.Add(customerEntity);
      _context.SaveChanges();

      return Ok(customerEntity);
      }
    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult UpdateCustomer(Guid id, UpdateCustomerDTO updateCustomerDTO)
      {
      var customer = _context.Customers.Find(id);

      if (customer is null)
        {
        return NotFound(id);
        }
      customer.FirstName = updateCustomerDTO.FirstName;
      customer.LastName = updateCustomerDTO.LastName;
      customer.Address1 = updateCustomerDTO.Address1;
      customer.Address2 = updateCustomerDTO.Address2;
      customer.City = updateCustomerDTO.City;
      customer.State = updateCustomerDTO.State;
      customer.Zipcode = updateCustomerDTO.Zipcode;
      customer.Phone = updateCustomerDTO.Phone;
      customer.Email = updateCustomerDTO.Email;
      customer.UserName = updateCustomerDTO.UserName;
      customer.Password = updateCustomerDTO.Password;

      _context.SaveChanges();
      return Ok(customer);
      }
    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteEmployee(Guid id)
      {
      var customer = _context.Customers.Find(id);

      if (customer is null)
        { return NotFound(id); }
      _context.Customers.Remove(customer);
      _context.SaveChanges();
      return Ok();

      }
    }
}
