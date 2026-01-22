using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KumaranCoffeeCorner.Data;
using KumaranCoffeeCorner.Models;

[Route("api")]
[ApiController]
public class AppController : ControllerBase {
    private readonly AppDbContext _context;
    public AppController(AppDbContext context) { _context = context; }

    // ==========================================
    // --- MENU (PRODUCT) OPERATIONS ---
    // ==========================================

    [HttpGet("menu")]
    public async Task<ActionResult> GetMenu() => Ok(await _context.Menus.ToListAsync());

    [HttpPost("menu")]
    public async Task<ActionResult> AddMenu(Menu item) {
        _context.Menus.Add(item);
        await _context.SaveChangesAsync();
        return Ok(item);
    }

    [HttpPut("menu/{id}")]
    public async Task<ActionResult> UpdateMenu(int id, Menu item) {
        if (id != item.Id) return BadRequest();
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("menu/{id}")]
    public async Task<ActionResult> DeleteMenu(int id) {
        var item = await _context.Menus.FindAsync(id);
        if (item == null) return NotFound();
        _context.Menus.Remove(item);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // ==========================================
    // --- BRANCH (OUTLET) OPERATIONS ---
    // ==========================================

    [HttpGet("branch")]
    public async Task<ActionResult> GetBranches() => Ok(await _context.Branches.ToListAsync());

    [HttpPost("branch")]
    public async Task<ActionResult> AddBranch(Branch branch) {
        _context.Branches.Add(branch);
        await _context.SaveChangesAsync();
        return Ok(branch);
    }

    [HttpPut("branch/{id}")]
    public async Task<ActionResult> UpdateBranch(int id, Branch branch) {
        if (id != branch.Id) return BadRequest();
        _context.Entry(branch).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("branch/{id}")]
    public async Task<ActionResult> DeleteBranch(int id) {
        var branch = await _context.Branches.FindAsync(id);
        if (branch == null) return NotFound();
        _context.Branches.Remove(branch);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}