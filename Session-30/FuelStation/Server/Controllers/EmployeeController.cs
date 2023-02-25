using FuelStation.Client.Pages;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Server.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {
        private readonly IEntityRepo<Employee> _employeeRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo) {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> Get() {
            var employeeList = _employeeRepo.GetAll();

            return employeeList.Select(employee => new EmployeeDto {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                Type = employee.Type
            });
        }

        [HttpGet("{Id}")]
        public async Task<EmployeeDto?> GetById(int id) {
            var result = _employeeRepo.GetById(id);

            return new EmployeeDto {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SalaryPerMonth = result.SalaryPerMonth,
                Type = result.Type
            };

        }

        [HttpPost]
        public async Task Post(EmployeeDto employee) {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.SalaryPerMonth, employee.HireDateStart, employee.Type);

            _employeeRepo.Create(newEmployee);
        }

        [HttpPut]
        public async Task Put(EmployeeDto employee) {
            var dbEmployee = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });


            if (dbEmployee is null) {
                return;
            }

            dbEmployee.Name = employee.Name;
            dbEmployee.Surname = employee.Surname;
            dbEmployee.HireDateStart = employee.HireDateStart;
            dbEmployee.SalaryPerMonth = employee.SalaryPerMonth;
            dbEmployee.Type = employee.Type;
            
            _employeeRepo.Update(employee.Id, dbEmployee);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id) {
            _employeeRepo.Delete(id);
        }

    }
}
