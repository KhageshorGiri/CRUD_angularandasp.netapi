using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentAPi.Repositories;
using PaymentAPi.Repositories_I;
using PaymentAPi.Entities;
using PaymentAPi.EntityDbContext;
using PaymentAPi.HelperExtension;
using PaymentAPi.Dtos;

namespace PaymentAPi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository repository;
        public PaymentController(IPaymentRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<PaymentDto> GetPayments()
        {
            var items = repository.GetPayments().Select(payment => payment.PaymentAsDto());
            return items;
        }

        [HttpGet("{Id}")]
        public ActionResult<PaymentDto> GetPayments(int Id)
        {
            Payment items = repository.GetPayments(Id);
            if(items is null)
            {
                return NotFound();
            }

            return items.PaymentAsDto();
        }

        [HttpPost]
        public ActionResult<CreatePaymentDto> Create(CreatePaymentDto payment)
        {
            Payment new_payment = new Payment
            {
                CardOwnerName = payment.CardOwnerName,
                ExpirationDate = payment.ExpirationDate,
                SecurityCode = payment.SecurityCode
            };

            repository.CreatePayment(new_payment);
            return CreatedAtAction(nameof(GetPayments), new { Id = new_payment.PyamentID}, new_payment.PaymentAsDto());
        }

        [HttpPut("{Id}")]
        public ActionResult<CreatePaymentDto> Update(int Id, CreatePaymentDto payment)
        {
            var exesting_value = repository.GetPayments(Id);

            if(exesting_value is null)
            {
                return NotFound();
            }

            exesting_value.CardOwnerName = payment.CardOwnerName;
            exesting_value.ExpirationDate = payment.ExpirationDate;
            exesting_value.SecurityCode = payment.SecurityCode;


            repository.UpdatePayment(exesting_value);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public ActionResult<PaymentDto> Delete(int Id)
        {
            var selected_value = repository.GetPayments(Id);
            if(selected_value is null)
            {
                return BadRequest();
            }
            repository.DeletPayment(Id);

            return NoContent();
        }
    }
}
