using EmployeeManagenent.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagenent.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly EmployeeDBContext _context ;
        
        protected readonly DbSet<T> table;
        
        public GenericRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        

        public virtual IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public virtual T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            Save();
        }
        //This method is going to update the record in the table
        //It will receive the object as an argument
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            Save();
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

