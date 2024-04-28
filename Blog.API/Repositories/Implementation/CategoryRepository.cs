using Blog.API.Data;
using Blog.API.Models.Domain;
using Blog.API.Repositories.Interface;

namespace Blog.API.Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.AddAsync(category);

            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
