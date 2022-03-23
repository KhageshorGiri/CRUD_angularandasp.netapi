using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPi.Dtos
{
    public class PaymentDto
    {
        public int PyamentID { get; set; }
        public string CardOwnerName { get; set; }
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }

    public class CreatePaymentDto
    {
        [Required]
        public string CardOwnerName { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string SecurityCode { get; set; }
    }
}
