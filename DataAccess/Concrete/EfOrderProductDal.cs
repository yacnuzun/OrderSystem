using DataAccess.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.DatabaseContext;
using Entities.Concrete;

namespace DataAccess.Concrete.EfConcrete
{
    public class EfOrderProductDal : EfEntityRepositoryBase<OrderSystemDbContext, OrderProduct>, IOrderProductDal
    {

    }
}
