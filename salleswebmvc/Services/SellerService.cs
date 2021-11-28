using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using salleswebmvc.Services;
using salleswebmvc.Models;
using salleswebmvc.Data;

namespace salleswebmvc.Services
{
    public class SellerService
    {
        private readonly salleswebmvcContext _context;

        public SellerService(salleswebmvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
