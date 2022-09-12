using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int id)
        {

            var resultData = _companyDal.Get(p => p.Id == id);
            var result = _companyDal.Delete(resultData);
            if (result)
                return new SuccessResult("Ürün Eklendi.");
            return new ErrorResult("Bir şey oldu :(");

        }

        public IDataResult<Company> Get(int id)
        {
            var result = _companyDal.Get(p => p.Id == id);
            return new SuccessDataResult<Company>(result, "Ürün Listelendi.");
        }

        public IDataResult<List<Company>> GetAll()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), "Ürünler Listelendi.");
        }


        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new SuccessResult("Ürün Eklendi.");
        }
    }
}
