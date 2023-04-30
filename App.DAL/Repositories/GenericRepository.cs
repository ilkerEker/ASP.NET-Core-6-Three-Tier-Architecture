using App.DAL.DataContext;
using App.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly DBTESTContext _dbContext;

        public GenericRepository(DBTESTContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<TModel>> GetEmployees()
        {
            try
            {
                return await _dbContext.Set<TModel>().ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
