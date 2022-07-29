﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Models;

namespace SallesWebMvc.Data
{
    public class SallesWebMvcContext : DbContext
    {
        public SallesWebMvcContext (DbContextOptions<SallesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SallesWebMvc.Models.Department> Department { get; set; }
        public DbSet<SallesWebMvc.Models.SalesRecord> SalesRecord { get; set; }
        public DbSet<SallesWebMvc.Models.Seller> Seller { get; set; }
    }
}
