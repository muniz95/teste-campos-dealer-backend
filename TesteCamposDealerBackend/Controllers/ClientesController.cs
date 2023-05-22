using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TesteCamposDealerBackend.Data;
using TesteCamposDealerBackend.Models;

namespace TesteCamposDealerBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly TesteCamposDealerBackendContext _context;

        public ClientesController(TesteCamposDealerBackendContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCustomer()
        {
          if (_context.Clientes == null)
          {
              return NotFound();
          }
            return await _context.Clientes.ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetCustomer(int id)
        {
          if (_context.Clientes == null)
          {
              return NotFound();
          }
            var customer = await _context.Clientes.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Cliente customer)
        {
            if (id != customer.idCliente)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cliente>> PostCustomer(Cliente customer)
        {
          if (_context.Clientes == null)
          {
              return Problem("Entity set 'TesteCamposDealerBackendContext.Customer'  is null.");
          }
            _context.Clientes.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.idCliente }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (_context.Clientes == null)
            {
                return NotFound();
            }
            var customer = await _context.Clientes.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return (_context.Clientes?.Any(e => e.idCliente == id)).GetValueOrDefault();
        }
    }
}
