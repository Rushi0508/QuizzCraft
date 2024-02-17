using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraft.Services
{
    [ServiceContract]
    public interface IOptionService
    {
        [OperationContract]
        Option GetOptionById(int optionId);


        [OperationContract]
        void AddOption(Option option);

        [OperationContract]
        void UpdateOption(Option option);

        [OperationContract]
        void DeleteOption(int optionId);

    }
}
