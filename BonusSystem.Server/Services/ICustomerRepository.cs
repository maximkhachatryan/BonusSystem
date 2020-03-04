using BonusSystem.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BonusSystem.Server.Services
{
    public interface ICustomerRepository
    {
        void Create(Customer item);
        Customer FindById(int id);
        IEnumerable<Customer> Get();
        IEnumerable<Customer> Get(Func<Customer, bool> predicate);
        bool Remove(Customer item);
        IEnumerable<Customer> GetWithInclude(params Expression<Func<Customer, object>>[] includeProperties);
        IEnumerable<Customer> GetWithInclude(Func<Customer, bool> predicate, params Expression<Func<Customer, object>>[] includeProperties);
    }
}
