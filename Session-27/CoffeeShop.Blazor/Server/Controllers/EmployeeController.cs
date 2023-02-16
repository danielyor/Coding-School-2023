using CoffeeShop.Blazor.Shared.Customer;
using CoffeeShop.Blazor.Shared.Employee;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {

            _employeeRepo = employeeRepo;

        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeListDto>> Get()
        {
            var employeeList = _employeeRepo.GetAll();

            return employeeList.Select(employee => new EmployeeListDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname=employee.Surname,
                SalaryPerMonth=employee.SalaryPerMonth,
                EmployeeType=employee.EmployeeType

            });

        }
        [HttpGet("{Id}")]
        public async Task<EmployeeEditDto?> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);
            return new EmployeeEditDto
            {

                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                SalaryPerMonth=result.SalaryPerMonth,
                EmployeeType=result.EmployeeType
            };

        }

        [HttpPost]
        public async Task Post(EmployeeEditDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.Surname,employee.SalaryPerMonth,employee.EmployeeType);
            newEmployee.Transactions = new();
            _employeeRepo.Create(newEmployee);//add?

        }
        [HttpPut]
        public async Task Put(EmployeeEditDto employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);
            itemToUpdate.Id = employee.Id;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;

            _employeeRepo.Update(employee.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _employeeRepo.Delete(id);

        }

    }

}

    

