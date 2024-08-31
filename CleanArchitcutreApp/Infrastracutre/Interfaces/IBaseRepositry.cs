namespace Infrastracutre.Interfaces
{
    public interface IBaseRepositry<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetById(int id);

        T Add(T item);

        T Update(T item);
        T Delete(T item);


    }
}
