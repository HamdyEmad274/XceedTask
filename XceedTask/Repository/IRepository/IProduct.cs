using XceedTask.Models;
using XceedTask.ViewModels;

namespace XceedTask.Repository.IRepository
{
    public interface IProduct
    {
        List<Category> GetCategories();
        List<GetAllProductWithCategoryNameVM> getAllProductWithCategoryNames();
        List<GetAllProductWithCategoryNameVM> GetProductsByCategoryId(int Id);
        List<Product> GetAllProductsFillterbyCategoryIdforuser(int id);
        List<Product> ShowProductsinSpecificTime();
        public Product GetProductAsNoTracking(int Id);
        string UploadImage(IFormFile image);
    }
}
