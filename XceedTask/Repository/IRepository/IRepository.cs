using XceedTask.Models;

namespace XceedTask.Repository.IRepository
{
    public interface IRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int Id);
        Product GetByName(string name);
        void Add(Product newProduct);
        void Update(Product editProduct);
        void Delete(int Id);
        void SaveChanges();

    }
}
