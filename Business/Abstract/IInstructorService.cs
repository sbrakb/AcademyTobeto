﻿using Core.Utilities.Result;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> Get(int id);
        IResult Add(Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult DeleteById(int id);
        IResult DeleteAll();
    }
}
