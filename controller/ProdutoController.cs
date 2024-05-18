using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperMarket.model.entity;
using SuperMarketAPI.Data;
using SuperMarketAPI.service;

namespace SuperMarket.controller;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly ProductsDbContext _context;
    private ProdutoService _produtoService;
    
    public ProdutoController(ProductsDbContext context, ProdutoService produtoService)
    {
        _context = context;
        _produtoService = produtoService;
    }
    
    [HttpPost("/produto")]
    public async Task<ActionResult> PostProduto(Produto produto)
    {
        if (!_produtoService.ValidarProduto(produto))
            return BadRequest("Preencha todos os campos");

        _context.Produtos.Add(produto);

        await _context.SaveChangesAsync();

        return Ok(produto);
    }
    
    [HttpGet("/produto")]
    public async Task<ActionResult> GetProducts()
    {
        return Ok(await _context.Produtos.ToListAsync());
    }

    [HttpPut("/produto")]
    public async Task<ActionResult> UpdateProduct(Produto produto)
    {
        var dbProduct = await _context.Produtos.FindAsync(produto.id);

        if (dbProduct == null)
            return NotFound();
        
        if (!_produtoService.ValidarProduto(produto))
            return BadRequest("Preencha todos os campos");

        dbProduct.Name = produto.Name;
        dbProduct.Price = produto.Price;
        dbProduct.Quantity = produto.Quantity;

        await _context.SaveChangesAsync();

        return Ok(produto);
    }
    
    [HttpDelete("/produto/{id}")]
    public async Task<ActionResult> DeleteProduct(Guid id)
    {
        var dbProduct = await _context.Produtos.FindAsync(id);

        if (dbProduct == null)
            return NotFound();

        _context.Produtos.Remove(dbProduct);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
