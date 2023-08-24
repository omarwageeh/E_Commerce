using E_Commerce.Data.Context;
using E_Commerce.Model;
using E_Commerce.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Repository.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly DataContext _context;
        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Order>> GetAllWithInclude(string include)
        {
            return  await _context.Set<Order>().Include(include).ToListAsync();
        }
    }
}
