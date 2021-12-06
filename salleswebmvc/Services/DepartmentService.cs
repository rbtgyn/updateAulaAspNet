using salleswebmvc.Data;
using salleswebmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace salleswebmvc.Services
{
    public class DepartmentService
    {
        private readonly salleswebmvcContext _context;

        public DepartmentService(salleswebmvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
