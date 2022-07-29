using System;
using System.Collections.Generic;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            //return Sellers.Sum(seller => seller.TotalSales(initial, final));
            return (from seller in Sellers
                    select seller.TotalSales(initial, final)).DefaultIfEmpty(0.00).Sum();
        }
    }
}
