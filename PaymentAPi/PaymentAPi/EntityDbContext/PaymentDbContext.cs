using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPi.Entities;

namespace PaymentAPi.EntityDbContext
{
    public class PaymentDbContext : DbContext
    {
        public PaymentDbContext(DbContextOptions<PaymentDbContext> options) : base(options)
        {

        }

        public DbSet<Payment> payments { get; set; }
    }
}
