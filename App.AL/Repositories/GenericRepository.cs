using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using App.DAL.DataContext;
using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;



namespace App.DAL.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly BlankContext _dbcontext;
        public GenericRepository(BlankContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                //return await _dbcontext.Set<TModel>().ToListAsync();
                return await _dbcontext.Users.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
}
             
           

          
    }

