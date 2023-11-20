﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfInstructorDal:EfEntityRepositoryBase<Instructor,AcademyContext>, IInstructorDal
    {
    }
}
