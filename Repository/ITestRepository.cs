using cqrswith8._0.Model;

namespace cqrswith8._0.Repository
{
    public interface ITestRepositoryace
    {
        Task<Test> GetByIdAsync(int id);
        Task<List<Test>> GetAllAsync(int pageNumber, int pageSize, string nameFilter);
        Task<int> CountAsync();
        Task<Test> CreateAsync(Test entity);
        Task<Test> UpdateAsync(Test entity);
        Task<bool> DeleteAsync(int id);
    }

}
