using DataBase.Models;
using Logic.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface IStudentWriteService
    {
        public void Add(Guid personId, Guid groupId);
        public Student Update(Guid id, UpdateStudentRequest updateStudentRequest);
        public Student Delete(Guid id);
    }
}
