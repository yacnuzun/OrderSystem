using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderProductManager : IOrderProductService
    {
        IOrderProductDal _orderProductDal;

        public OrderProductManager(IOrderProductDal orderProductDal)
        {
            _orderProductDal = orderProductDal;
        }

        public IResult Add(OrderProduct orderProduct)
        {
            _orderProductDal.Add(orderProduct);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var resultData = _orderProductDal.Get(p => p.Id == id);
            var result = _orderProductDal.Delete(resultData);
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<OrderProduct> Get(int id)
        {
            var result = _orderProductDal.Get(p => p.Id == id);
            return new SuccessDataResult<OrderProduct>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<OrderProduct>> GetAll()
        {
            return new SuccessDataResult<List<OrderProduct>>(_orderProductDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(OrderProduct orderProduct)
        {
            _orderProductDal.Update(orderProduct);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}
