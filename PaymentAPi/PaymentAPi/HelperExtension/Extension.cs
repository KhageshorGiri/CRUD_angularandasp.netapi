using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPi.Entities;
using PaymentAPi.Dtos;

namespace PaymentAPi.HelperExtension
{
    public static class Extension
    {
        public static PaymentDto PaymentAsDto(this Payment payment)
        {
            return new PaymentDto
            {
                PyamentID = payment.PyamentID,
                CardOwnerName = payment.CardOwnerName,
                ExpirationDate = payment.ExpirationDate,
                SecurityCode = payment.SecurityCode
            };
        }
    }
}
