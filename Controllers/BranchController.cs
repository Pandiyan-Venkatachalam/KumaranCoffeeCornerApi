// using Microsoft.AspNetCore.Mvc;
// using KumaranCoffeeCorner.Models;
// using KumaranCoffeeCorner.Services;

// namespace KumaranCoffeeCorner.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class BranchController : ControllerBase
//     {
//         private readonly IBranchService _service;
//         public BranchController(IBranchService service) => _service = service;

//         [HttpGet]
//         public async Task<IActionResult> GetAll() => Ok(await _service.GetBranchesAsync());

//         [HttpGet("{id}")]
//         public async Task<IActionResult> GetById(int id)
//         {
//             var branch = await _service.GetByIdAsync(id);
//             return branch == null ? NotFound() : Ok(branch);
//         }

//         [HttpPost]
//         public async Task<IActionResult> Create(Branch branch)
//         {
//             await _service.AddBranchAsync(branch);
//             return CreatedAtAction(nameof(GetById), new { id = branch.Id }, branch);
//         }

//         [HttpPut("{id}")]
//         public async Task<IActionResult> Update(int id, Branch branch)
//         {
//             if (id != branch.Id) return BadRequest();
//             await _service.UpdateBranchAsync(branch);
//             return NoContent();
//         }

//         [HttpDelete("{id}")]
//         public async Task<IActionResult> Delete(int id)
//         {
//             await _service.DeleteBranchAsync(id);
//             return NoContent();
//         }
//     }
// }