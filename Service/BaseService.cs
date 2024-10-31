using DAL;

namespace Service
{
    public class BaseService<T, TDao> where TDao : BaseDao<T>, new()
    {
        protected readonly TDao dao = new();

        public async Task<bool> IsDatabaseConnctionAvailable()
        {
            return await dao.IsDatabaseConnctionAvailable();
        }
    }
}