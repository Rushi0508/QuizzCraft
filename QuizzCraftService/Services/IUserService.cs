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
    public interface IUserService
    {
        [OperationContract]
        string AddUser(User user);

    }
}
