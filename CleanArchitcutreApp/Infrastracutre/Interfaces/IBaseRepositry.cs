namespace Infrastracutre.Interfaces
{
    public interface IBaseRepositry<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        T Add(T item);

        T Update(T item);

    }
}
