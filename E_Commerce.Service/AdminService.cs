using E_Commerce.Dto;
using E_Commerce.Model;
using E_Commerce.Repository.Interface;
using E_Commerce.Repository.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    public class AdminService
    {
        private readonly IUnitOfWork _uow;
        public AdminService(IUnitOfWork uow) 
        {
            _uow = uow;
        }
        public void AddAdmin(AdminDto admin)
        {
            Admin user = new Admin()
            {
                FullName = admin.FullName,
                Email = admin.Email,
                Password = admin.Password,
                JobTitle = admin.JobTitle,
                HireDate = admin.HireDate,
            };
            _uow.UserRepository.Add(user);
            _uow.AdminRepository.Add(user);
            _uow.SaveChanges();
        }
        public async Task<IEnumerable?> GetAdmins()
        {

            var admins = await _uow.AdminRepository.GetAll();
            return admins;
        }
        public async Task DeleteAdmin(string email)
        {
            var admin = await _uow.AdminRepository.Get(a => a.Email == email);
            if(admin == null) 
            {
                return;
            }
            _uow.AdminRepository.Delete(admin);
            _uow.SaveChanges();
        }
        public async void EditAdmin(AdminDto admin)
        {
            var user = await _uow.AdminRepository.Get(a=>a.Email == admin.Email);
            if (user == null)
            {
               return;
            }
            user.FullName = admin.FullName;
            user.JobTitle = admin.JobTitle;
            user.Password = admin.Password;
            _uow.AdminRepository.Update(user);
            _uow.SaveChanges();
        }

        public async Task<IEnumerable?> GetCategories()
        {
            return await _uow.CategoryRepository.GetAll();
        }
        public void AddCategory(string name)
        {
            Category category = new Category();
            category.Name = name;
            _uow.CategoryRepository.Add(category);
            _uow.SaveChanges();
        }
        public async void EditCategory(string from, string to)
        {
            var category = await _uow.CategoryRepository.Get(a=>a.Name == from);
            if (category == null)
                return;
            category.Name = to;
            _uow.CategoryRepository.Update(category);
            _uow.SaveChanges();
        }
        public async void DeleteCategory(string name)
        {
            var category = await _uow.CategoryRepository.Get(c=>c.Name== name);
            if (category == null)
                return;
            _uow.CategoryRepository.Delete(category);
            _uow.SaveChanges();
        }
        public async Task<IEnumerable<Product>?> GetProducts()
        {
            return await _uow.ProductRepository.GetAll();
        }
        public async Task<IEnumerable<Product>?> GetProducts(Expression<Func<Product, bool>> predicate)
        {
            return await _uow.ProductRepository.GetAll(predicate);
        }
        public async void AddProduct(ProductDto product)
        {
            var cat = await _uow.CategoryRepository.Get(c => c.Name == product.catName) ?? await _uow.CategoryRepository.Add(new Category { Name = product.catName });
            if (cat == null) return;
            Product prod = new Product()
            {
                NameEn = product.NameEn,
                NameAr = product.NameAr,
                UnitPrice = product.UnitPrice,
                StockQuantity = product.StockQuantity,
                Category = cat,
            };
            _uow.ProductRepository.Add(prod);
            _uow.SaveChanges();
        }
        public async void UpdateProduct(ProductDto product)
        {
            var cat = await _uow.CategoryRepository.Get(c => c.Name == product.catName) ?? await _uow.CategoryRepository.Add(new Category { Name = product.catName });
            if (cat == null) return;
            Product prod = new Product()
            {
                NameEn = product.NameEn,
                NameAr = product.NameAr,
                UnitPrice = product.UnitPrice,
                StockQuantity = product.StockQuantity,
                Category = cat,
            };
            _uow.ProductRepository.Update(prod);
            _uow.SaveChanges();
        }
        public async void DeleteProduct(Guid id)
        {
            var product = await _uow.ProductRepository.Get(p => p.Id == id);
            if(product == null) return;
            _uow.ProductRepository.Delete(product);
        }
    }
}
