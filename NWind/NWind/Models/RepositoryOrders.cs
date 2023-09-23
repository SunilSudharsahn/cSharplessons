using Microsoft.AspNetCore.Mvc.Rendering;
using NWind.Models;

namespace Nwind.Models
{
    public class RepositoryOrder
    {
        private readonly NorthwindContext _context;
       
        public RepositoryOrder() { }
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }





        public List<Order> Orders()
        {
            return _context.Orders.ToList();
        }
    }
}