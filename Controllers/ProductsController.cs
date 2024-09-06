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
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /* [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
 */
        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
    public IActionResult AddProduct(AddProductDTO addProductDTO)
      {
      var ProductEntity = new Product()
        {
        Name = addProductDTO.Name,
        Price = addProductDTO.Price,
        CategoryId = addProductDTO.CategoryId,
        Description = addProductDTO.Description,
        ImageOne = addProductDTO.ImageOne,
        ImageTwo = addProductDTO.ImageTwo,
        ImageThree = addProductDTO.ImageThree,
        ImageFour = addProductDTO.ImageFour,
        ImageFive = addProductDTO.ImageFive,
        UnitsInStock = addProductDTO.UnitsInStock,
        UnitsOnOrder = addProductDTO.UnitsOnOrder,
        UnitsReorderLevel = addProductDTO.UnitsReorderLevel,
        SupplierId = addProductDTO.SupplierId,
        UnitsSold = addProductDTO.UnitsSold,
        UnitWeight = addProductDTO.UnitWeight,
        UnitDimensions = addProductDTO.UnitDimensions,
        UnitCost = addProductDTO.UnitCost,
        
        };
      _context.Products.Add(ProductEntity);
      _context.SaveChanges();

      return Ok(ProductEntity);
      }
    }
}
