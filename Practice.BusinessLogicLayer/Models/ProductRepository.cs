using Practice.BusinessLogicLayer.Data;
using Practice.DataAccessLayer.Entities;


namespace Practice.BusinessLogicLayer.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            if(product is not null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            if(product is not null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            if(product != null)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
            }
        }
    }
}
