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
    public class CategoriesController : ControllerBase
    {
        private readonly StoreContext _context;

        public CategoriesController(StoreContext context)
        {
            this._context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public IActionResult GetCategories()
        {
          var Category = _context.Categories.ToList();
          return Ok(Category);
        }   

        // GET: api/Categories/5
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetCategory(int id)
        {
            var Category = _context.Categories.Find(id);

            if (Category is null)
            {
                return NotFound();
            }          

            return Ok(Category);
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754



        
        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
    public IActionResult AddCategory(AddCategoryDTO addCategoryDTO)
      {
      var CategoryEntity = new Category()
        {
        Name = addCategoryDTO.Name,
                
        };
      _context.Categories.Add(CategoryEntity);
      _context.SaveChanges();

      return Ok(CategoryEntity);
      }
    [HttpPut]
    [Route("{id:guid}")]
    public IActionResult UpdateCategory(Guid id, UpdateCategoryDTO updateCategoryDTO)
      {
      var Category = _context.Categories.Find(id);

      if (Category is null)
        {
        return NotFound(id);
        }
      Category.Name = updateCategoryDTO.Name;
      

      _context.SaveChanges();
      return Ok(Category);
      }
    [HttpDelete]
    [Route("{id:guid}")]
    public IActionResult DeleteEmployee(Guid id)
      {
      var Category = _context.Categories.Find(id);

      if (Category is null)
        { return NotFound(id); }
      _context.Categories.Remove(Category);
      _context.SaveChanges();
      return Ok();

      }
    }
}
