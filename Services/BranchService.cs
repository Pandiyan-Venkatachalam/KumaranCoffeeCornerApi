// using KumaranCoffeeCorner.Models;
// using KumaranCoffeeCorner.Repositories;

// namespace KumaranCoffeeCorner.Services
// {
//     public class BranchService : IBranchService
//     {
//         private readonly IBranchRepository _repo;
//         public BranchService(IBranchRepository repo) => _repo = repo;

//         public async Task<IEnumerable<Branch>> GetBranchesAsync() => await _repo.GetAllAsync();
//         public async Task<Branch?> GetByIdAsync(int id) => await _repo.GetByIdAsync(id);
//         public async Task AddBranchAsync(Branch branch) => await _repo.AddAsync(branch);
//         public async Task UpdateBranchAsync(Branch branch) => await _repo.UpdateAsync(branch);
//         public async Task DeleteBranchAsync(int id) => await _repo.DeleteAsync(id);
//     }
// }