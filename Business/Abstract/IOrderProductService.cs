using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderProductService
    {
        IDataResult<List<OrderProduct>> GetAll();
        IDataResult<OrderProduct> Get(int id);
        IResult Add(OrderProduct orderProduct);
        IResult Update(OrderProduct orderProduct);
        IResult Delete(int id);

    }
}
