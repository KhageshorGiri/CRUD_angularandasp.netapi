using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPi.Entities
{
    public class Payment
    {
        [Key]
        public int PyamentID { get; set; }
        public string CardOwnerName { get; set;}
        public string ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
    }
}
