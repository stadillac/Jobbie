﻿using System.Linq.Expressions;

namespace Jobbie.Db.Services
{
    /// <summary>
    /// The base service. Used to manage the majority of
    /// basic CRUD operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseService<T>
    {
        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public T Create(T entity);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public T Delete(T entity);

        /// <summary>
        /// Gets the specified entity based on predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public T? Get(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Lists the specified entities.
        /// </summary>
        /// <returns></returns>
        public ICollection<T> List();

        /// <summary>
        /// Lists the specified entities based on predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public ICollection<T> List(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public T Update(T entity);
    }
}
