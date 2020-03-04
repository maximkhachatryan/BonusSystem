using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BonusSystem.Server.Models;

namespace BonusSystem.Server.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Create(Customer item)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetWithInclude(params Expression<Func<Customer, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetWithInclude(Func<Customer, bool> predicate, params Expression<Func<Customer, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
