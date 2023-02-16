using CoffeeShop.Blazor.Shared.Transaction;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        public TransactionController(IEntityRepo<Transaction> transactionRepo)
        {

            _transactionRepo = transactionRepo;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var transactionList = _transactionRepo.GetAll();

            return transactionList.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                TotalPrice = transaction.TotalPrice,
                PaymentMethod = transaction.PaymentMethod,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                //TransactionLines = transaction.TransactionLines,
            });

        }

        /*
        [HttpGet("{Id}")]
        public async Task<CustomerEditDto?> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {

                Id = id,
                Code = result.Code,
                Description = result.Description
            };

        }

        [HttpPost]
        public async Task Post(CustomerEditDto customer)
        {
            var newCustomer = new Customer(customer.Code, customer.Description);
            newCustomer.Transactions = new();
            _customerRepo.Create(newCustomer);

        }

        [HttpPut]
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);
            itemToUpdate.Id = customer.Id;
            itemToUpdate.Code = customer.Code;
            itemToUpdate.Description = customer.Description;


            _customerRepo.Update(customer.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _customerRepo.Delete(id);

        }
        */
    }

}



