using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IDataResult<List<Company>> GetAll();
        IDataResult<Company> Get(int id);
        IResult Add(Company company);
        IResult Update(Company company);
        IResult Delete(int id);

    }
}
