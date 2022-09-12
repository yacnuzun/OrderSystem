using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IDataResult<Order> Add(Order order)
        {
            _orderDal.Add(order);
            
            return new SuccessDataResult<Order>(_orderDal.Get(o=>o.Id==order.Id),"Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var resultData = _orderDal.Get(p => p.Id == id);
            var result = _orderDal.Delete(resultData);
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<Order> Get(int id)
        {
            var result = _orderDal.Get(p => p.Id == id);
            return new SuccessDataResult<Order>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}
