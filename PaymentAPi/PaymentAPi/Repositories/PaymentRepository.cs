using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPi.Entities;
using PaymentAPi.Dtos;
using PaymentAPi.EntityDbContext;
using PaymentAPi.Repositories_I;
using Microsoft.EntityFrameworkCore;

namespace PaymentAPi.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentDbContext _context;

        public PaymentRepository(PaymentDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Payment> GetPayments()
        {
            var items = _context.payments.ToList();
            return items;
        }

        public Payment GetPayments(int Id)
        {
            var payment = _context.payments.Find(Id);           
            return payment;
        }

        public void CreatePayment(Payment payment)
        {          
           _context.payments.Add(payment);
            _context.SaveChanges();

        }
        public void UpdatePayment(Payment payment)
        {
            _context.Entry(payment).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeletPayment(int Id)
        {
            var selected_value = _context.payments.Find(Id);
            _context.payments.Remove(selected_value);
            _context.SaveChanges();
        }

        
    }
}
