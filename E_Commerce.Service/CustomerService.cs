using E_Commerce.Dto;
using E_Commerce.Model;
using E_Commerce.Model.Enum;
using E_Commerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Service
{
    
    public class CustomerService
    {
        private readonly IUnitOfWork _uow;
        public CustomerService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Product>?> GetProducts(Expression<Func<Product, bool>> predicate)
        {
            return await _uow.ProductRepository.GetAllWithInclude(predicate, "Category");
        }
        public async void UpdateProduct(Product product)
        { 
            _uow.ProductRepository.Update(product);
            _uow.SaveChanges();
        }
        public async Task<IEnumerable<Order>?> GetOrders(Expression<Func<Order, bool>> predicate)
        {
            return await _uow.OrderRepository.GetAllWithInclude(predicate, "Customer");
        }
        public async Task<Order> AddOrder(Order order)
        {
            return await _uow.OrderRepository.Add(order);
        }
        public bool UpdateOrder(Order order)
        {
            _uow.OrderRepository.Update(order);
            return _uow.SaveChanges() > 0;
        }
        public async Task<OrderDetails> AddOrderDetails(OrderDetails orderDetails)
        {
            return await _uow.OrderDetailsRepository.Add(orderDetails);
        }
        public async Task<OrderDetails> GetOrderDetails(string orderId, string productId)
        {
            return await _uow.OrderDetailsRepository.Get(od => od.OrderId == Guid.Parse(orderId) && od.ProductId == Guid.Parse(productId));
        }
        public async Task RemoveOrderDetails(string orderId, string productId)
        {

            _uow.OrderDetailsRepository.Delete(await GetOrderDetails(orderId, productId));
            _uow.SaveChanges();
        }
        public async void UpdateOrderDetails(OrderDetails orderDetails)
        {
            _uow.OrderDetailsRepository.Update(orderDetails);
            _uow.SaveChanges();
        }

    }
}
