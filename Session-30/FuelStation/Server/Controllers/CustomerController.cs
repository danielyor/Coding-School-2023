using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase {
        private readonly IEntityRepo<Customer> _customerRepo;

        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerDto>> Get() {
            var customerList = _customerRepo.GetAll();

            return customerList.Select(customer => new CustomerDto {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            });
        }

        [HttpGet("{Id}")]
        public async Task<CustomerDto?> GetById(int id) {
            var result = _customerRepo.GetById(id);

            return new CustomerDto {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber
            };

        }

        [HttpPost]
        public async Task Post(CustomerDto customer) {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);

            _customerRepo.Create(newCustomer);
        }

        [HttpPut]
        public async Task Put(CustomerDto customer) {
            var dbCustomer = await Task.Run(() => { return _customerRepo.GetById(customer.Id); });


            if (dbCustomer is null) {
                return;
            }

            dbCustomer.Name = customer.Name;
            dbCustomer.Surname = customer.Surname;
            dbCustomer.CardNumber = customer.CardNumber;
            
            _customerRepo.Update(customer.Id, dbCustomer);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _customerRepo.Delete(id);
        }

    }
}
