using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _icategoryDal;
        public CategoryManager(ICategoryDal icategoryDal)
        {
            _icategoryDal = icategoryDal;
        }
        public IResult Add(Category category)
        {
            _icategoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            _icategoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);
        }

        public IResult DeleteAll()
        {
            foreach (var c in _icategoryDal.GetAll())
            {
                _icategoryDal.Delete(c);
            }
            return new SuccessResult(Messages.DeletedCategoryList);
        }

        public IResult DeleteById(int id)
        {
            _icategoryDal.Delete(_icategoryDal.Get(c => c.Id == id));
            return new SuccessResult(Messages.DeletedById);
        }

        public IDataResult<Category> Get(int id)
        {
            return new SuccessDataResult<Category>(_icategoryDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour==21)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Category>>(_icategoryDal.GetAll());
        }

        public IResult Update(Category category)
        {
            _icategoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
