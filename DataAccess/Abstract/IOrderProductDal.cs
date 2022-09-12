using DataAccess.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IOrderProductDal : IEntityRepository<OrderProduct>
    {
    }
}
