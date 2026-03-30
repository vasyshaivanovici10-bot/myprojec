using Microsoft.EntityFrameworkCore;
using MyProject.DataAccess;
using MyProject.Domain;

namespace MyProject.BusinessLayer;

public class ProductService
{
    private readonly AppDbContext _context;
    public ProductService(AppDbContext context) { _context = context; }

    public async Task<List<Product>> GetAll() => await _context.Products.ToListAsync();

    public async Task<Product> Create(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
