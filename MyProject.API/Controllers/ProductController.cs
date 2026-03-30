using Microsoft.AspNetCore.Mvc;
using MyProject.BusinessLayer;
using MyProject.Domain;

namespace MyProject.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get() => Ok(await _service.GetAll());

    [HttpPost]
    public async Task<IActionResult> Create(Product product)
        => Ok(await _service.Create(product));
}
