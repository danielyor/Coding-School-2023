using CoffeeShop.Blazor.Shared;
using CoffeeShop.Blazor.Shared.Customer;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CoffeeShop.Blazor.Server.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {

            _customerRepo = customerRepo;

        }
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var customerList = _customerRepo.GetAll();

            return customerList.Select(customer => new CustomerListDto
            {
                Id = customer.Id,
                Code = customer.Code,
                Description = customer.Description


            });

        }
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

    }

}



