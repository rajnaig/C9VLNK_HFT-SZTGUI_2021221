using C9VLNK_HFT_2021221.Data;
using C9VLNK_HFT_2021221.Repository.Interfaces;
using System.Linq;

namespace C9VLNK_HFT_2021221.Repository.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected MusicContext ctx;
        protected Repository(MusicContext ctx)
        {
            this.ctx = ctx;
        }
        public IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }
        public abstract T GetOne(int id);
    }
}
