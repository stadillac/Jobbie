namespace Jobbie.Db.Services
{
    public interface IBaseService<T>
    {
        public T Create(T entity);
        public T Update(T entity);
        public T Delete(T entity);
    }
}
