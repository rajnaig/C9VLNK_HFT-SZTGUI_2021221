using System.Linq;

namespace C9VLNK_HFT_2021221.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetOne(int id);
        IQueryable<T> GetAll();
    }
}
