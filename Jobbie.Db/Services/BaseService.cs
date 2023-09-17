﻿using Jobbie.Db.Models;

namespace Jobbie.Db.Services
{
    public class BaseService<T> : IBaseService<T> where T : Audit
    {
        protected ApplicationContext _context;

        public BaseService(ApplicationContext context)
        {
            _context = context;
        }

        public virtual T Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual T Delete(T entity)
        {
            entity.IsDeleted = true;
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
