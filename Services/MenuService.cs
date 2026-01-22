// using KumaranCoffeeCorner.Models;
// using KumaranCoffeeCorner.Repositories;

// namespace KumaranCoffeeCorner.Services
// {
//     public class MenuService : IMenuService
//     {
//         private readonly IMenuRepository _repo;
//         public MenuService(IMenuRepository repo) => _repo = repo;

//         public async Task<IEnumerable<MenuItem>> GetMenuAsync() => await _repo.GetAllAsync();
//         public async Task<MenuItem?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);
//         public async Task AddItemAsync(MenuItem item) => await _repo.AddAsync(item);
//         public async Task UpdateItemAsync(MenuItem item) => await _repo.UpdateAsync(item);
//         public async Task DeleteItemAsync(int id) => await _repo.DeleteAsync(id);
//     }
// }