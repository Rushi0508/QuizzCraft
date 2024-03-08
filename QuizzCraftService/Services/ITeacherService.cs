using QuizzCraftService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Services
{
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        string AddTeacher(Teacher teacher);

        [OperationContract]
        Teacher GetTeacherByEmail(string email);

        [OperationContract]
        Teacher GetTeacherById(int id);

        [OperationContract] 
        Teacher VerifyTeacher(string email, string epassword);
    }
}
