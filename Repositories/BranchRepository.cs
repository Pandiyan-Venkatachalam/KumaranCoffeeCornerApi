// using Microsoft.EntityFrameworkCore;
// using KumaranCoffeeCorner.Data;
// using KumaranCoffeeCorner.Models;

// namespace KumaranCoffeeCorner.Repositories
// {
//     public class BranchRepository : IBranchRepository
//     {
//         private readonly AppDbContext _context;
//         public BranchRepository(AppDbContext context) => _context = context;

//         public async Task<IEnumerable<Branch>> GetAllAsync() 
//             => await _context.Branches.AsNoTracking().ToListAsync();

//         public async Task<Branch?> GetByIdAsync(int id) 
//             => await _context.Branches.FindAsync(id);

//         public async Task AddAsync(Branch branch)
//         {
//             await _context.Branches.AddAsync(branch);
//             await _context.SaveChangesAsync();
//         }

//         public async Task UpdateAsync(Branch branch)
//         {
//             _context.Branches.Update(branch);
//             await _context.SaveChangesAsync();
//         }

//         public async Task DeleteAsync(int id)
//         {
//             var branch = await _context.Branches.FindAsync(id);
//             if (branch != null)
//             {
//                 _context.Branches.Remove(branch);
//                 await _context.SaveChangesAsync();
//             }
//         }
//     }
// }