using DataAccess.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICompanyDal : IEntityRepository<Company>
    {
    }
}
