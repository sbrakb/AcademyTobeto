using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public int InstructorId { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public Instructor? Instructor { get; set; }
        public Category? Category { get; set; }
    }
}
