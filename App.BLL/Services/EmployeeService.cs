using App.BLL.Services.Contracts;
using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Services
{
    public class EmployeeService:IEmployeeService   
    {
        private readonly IGenericRepository<Employee> _repository;
        public EmployeeService(IGenericRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            try
            {
                return await _repository.GetEmployees();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
