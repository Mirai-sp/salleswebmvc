using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SallesWebMvc.Data;
using SallesWebMvc.Models;

namespace SallesWebMvc.Services
{
    public class SellerService
    {
        private readonly SallesWebMvcContext _context;

        public SellerService(SallesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
