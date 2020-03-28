using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebVendor.Models.Entities {
    public class Seller {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> salesRecords { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            salesRecords.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            salesRecords.Remove(sr);
        }
        public double totalSales(DateTime Initial, DateTime Final)
        {
            return salesRecords.Where(sr => sr.Date >= Initial && sr.Date <= Final).Sum(sr => sr.Amount);
        }
    }
}
