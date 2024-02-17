using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraft.Services
{
    public class OptionService : IOptionService
    {
        private readonly QuizzContext quizzContext;

        public OptionService()
        {
            this.quizzContext = new QuizzContext();
        }

        public Option GetOptionById(int optionId)
        {
            return quizzContext.Options.FirstOrDefault(o => o.OptionID == optionId);
        }
        public void AddOption(Option option)
        {
            quizzContext.Options.Add(option);
            quizzContext.SaveChanges();
        }
        public void DeleteOption(int optionId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOption(Option option)
        {
            throw new NotImplementedException();
        }
    }
}
