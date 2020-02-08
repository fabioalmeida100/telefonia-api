using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telefonia.Model.Base;
using Telefonia.Model.Context;

namespace Telefonia.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        public MySQLContext _context;
        public DbSet<T> dataset;

        public GenericRepository(MySQLContext context)
        {
            _context = context;            
            dataset = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public void Delete(long id)
        {
            var entity = dataset.SingleOrDefault(e => e.Id == id);
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> FindAll()
        {
            var entities = dataset.ToList();
            return entities;
        }

        public T FindById(long id)
        {
            var entity = dataset.SingleOrDefault(p => p.Id == id);
            return entity;
        }

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id == item.Id);
            if (result != null)
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }

            return item;
        }
    }
}
