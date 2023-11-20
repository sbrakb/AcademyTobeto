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
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);
        }

        public IResult DeleteAll()
        {
            foreach (var instructor in _instructorDal.GetAll())
            {
                _instructorDal.Delete(instructor);
            }
            return new SuccessResult(Messages.DeletedInstructorList);
        }

        public IResult DeleteById(int id)
        {
            _instructorDal.Delete(_instructorDal.Get(i => i.Id == id));
            return new SuccessResult(Messages.DeletedById);
        }

        public IDataResult<Instructor> Get(int id)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(i => i.Id == id));
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(), Messages.InstructorList);
        }

        public IResult Update(Instructor instructor)
        {
            if (instructor.FirstName == "zaha")
            {
                return new ErrorResult("zaha cant updated");
            }
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.Updated);
        }
    }
}
