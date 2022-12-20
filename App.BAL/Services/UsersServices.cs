using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App.DAL.Models;
using App.DAL.Repositories.Contracts;
using App.BLL.Services.Contracts;

namespace App.BLL.Services
{
    public class UsersServices:IUsersServices
    {
        private readonly IGenericRepository<User> _repository;

        public UsersServices(IGenericRepository<User> repository) 
        {
            _repository = repository;
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                return await _repository.GetUsers();
            }

            catch
            {
                throw;
            
            }
        }
    }
    
    
}
