using Core.Utilities.Result;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetAll();
        IDataResult<Category> Get(int id);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
        IResult DeleteById(int id);
        IResult DeleteAll();
    }
}
