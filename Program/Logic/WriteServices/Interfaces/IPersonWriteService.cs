using DataBase.Models;
using Logic.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.WriteServices.Interfaces
{
    public interface IPersonWriteService
    {
        public Guid Add(Person person);
        public void Update(Guid id, Person person);
        public void Delete(Guid id);
    }
}
