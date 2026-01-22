// using Microsoft.EntityFrameworkCore;
// using KumaranCoffeeCorner.Data;
// using KumaranCoffeeCorner.Models;

// namespace KumaranCoffeeCorner.Repositories
// {
//     public class MenuRepository : IMenuRepository
//     {
//         private readonly AppDbContext _context;
//         public MenuRepository(AppDbContext context) => _context = context;

//         public async Task<IEnumerable<MenuItem>> GetAllAsync() 
//             => await _context.MenuItems.AsNoTracking().ToListAsync();

//         public async Task<MenuItem?> GetByIdAsync(int id) 
//             => await _context.MenuItems.FindAsync(id);

//         public async Task AddAsync(MenuItem item)
//         {
//             await _context.MenuItems.AddAsync(item);
//             await _context.SaveChangesAsync();
//         }

//         public async Task UpdateAsync(MenuItem item)
//         {
//             _context.MenuItems.Update(item);
//             await _context.SaveChangesAsync();
//         }

//         public async Task DeleteAsync(int id)
//         {
//             var item = await _context.MenuItems.FindAsync(id);
//             if (item != null)
//             {
//                 _context.MenuItems.Remove(item);
//                 await _context.SaveChangesAsync();
//             }
//         }
//     }
// }