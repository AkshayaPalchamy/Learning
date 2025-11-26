namespace DependencyInjectionAPI
{
    public class CategoryRepository: ICategoryRepository
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Beverages" },
                new Category { CategoryId = 2, CategoryName = "Condiments" },
                new Category { CategoryId = 3, CategoryName = "Confections" }
            };
        }
    }
}
