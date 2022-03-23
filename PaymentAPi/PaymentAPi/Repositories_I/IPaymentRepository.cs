using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPi.Dtos;
using PaymentAPi.Entities;

namespace PaymentAPi.Repositories_I
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetPayments();

        Payment GetPayments(int Id);

        void CreatePayment(Payment payment);

        void UpdatePayment(Payment payment);

        void DeletPayment(int Id);

    }
}
