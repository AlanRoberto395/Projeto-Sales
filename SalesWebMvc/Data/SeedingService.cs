using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Linq;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private readonly SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; 
            }
            Department d1 = new Department { Name = "Computers" };
            Department d2 = new Department { Name = "Electronics" };
            Department d3 = new Department { Name = "Fashion" };
            Department d4 = new Department { Name = "Books" };

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.SaveChanges(); 

            Seller s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998, 4, 21), BaseSalary = 1000.0, Department = d1 };
            Seller s2 = new Seller { Name = "Peter Parker", Email = "peter@gmail.com", BirthDate = new DateTime(2001, 8, 10), BaseSalary = 1200.0, Department = d1 };
            Seller s3 = new Seller { Name = "Barack Obama", Email = "barack@gmail.com", BirthDate = new DateTime(1961, 8, 4), BaseSalary = 3000.0, Department = d2 };
            Seller s4 = new Seller { Name = "Leonardo da Vinci", Email = "vince@gmail.com", BirthDate = new DateTime(1975, 4, 15), BaseSalary = 2500.0, Department = d2 };
            Seller s5 = new Seller { Name = "Ana Júlia", Email = "ana@gmail.com", BirthDate = new DateTime(1995, 3, 12), BaseSalary = 1500.0, Department = d3 };
            Seller s6 = new Seller { Name = "Fausto Dias", Email = "fausto@gmail.com", BirthDate = new DateTime(1988, 11, 29), BaseSalary = 1800.0, Department = d3 };

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SaveChanges();

            SalesRecord r1 = new SalesRecord { Date = new DateTime(2018, 09, 25), Amount = 11000.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord r2 = new SalesRecord { Date = new DateTime(2018, 09, 04), Amount = 7000.0, Status = SalesStatus.Billed, Seller = s3 };
            SalesRecord r3 = new SalesRecord { Date = new DateTime(2018, 09, 13), Amount = 4000.0, Status = SalesStatus.Canceled, Seller = s4 };
            SalesRecord r4 = new SalesRecord { Date = new DateTime(2018, 09, 01), Amount = 8000.0, Status = SalesStatus.Billed, Seller = s5 };
            SalesRecord r5 = new SalesRecord { Date = new DateTime(2018, 09, 21), Amount = 3000.0, Status = SalesStatus.Billed, Seller = s3 };
            SalesRecord r6 = new SalesRecord { Date = new DateTime(2018, 09, 15), Amount = 2000.0, Status = SalesStatus.Billed, Seller = s1 };
            SalesRecord r7 = new SalesRecord { Date = new DateTime(2018, 09, 28), Amount = 13000.0, Status = SalesStatus.Billed, Seller = s2 };
            SalesRecord r8 = new SalesRecord { Date = new DateTime(2018, 09, 11), Amount = 4000.0, Status = SalesStatus.Billed, Seller = s4 };
            SalesRecord r9 = new SalesRecord { Date = new DateTime(2018, 09, 14), Amount = 11000.0, Status = SalesStatus.Pending, Seller = s6 };
            SalesRecord r10 = new SalesRecord { Date = new DateTime(2018, 09, 07), Amount = 9000.0, Status = SalesStatus.Billed, Seller = s6 };

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);
            _context.SaveChanges();
        }
    }
}