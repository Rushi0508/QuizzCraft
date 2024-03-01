using QuizzCraft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraft.Services
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
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
        public int AddOption(Option option)
        {
            quizzContext.Options.Add(option);
            quizzContext.SaveChanges();

            return option.OptionID;
        }
        public void DeleteOption(int optionId)
        {
            var optionToDelete = quizzContext.Options.Find(optionId);
        
            if (optionToDelete != null)
            {
                quizzContext.Options.Remove(optionToDelete); // Remove the option from the context
                quizzContext.SaveChanges(); // Save changes to the database
            }
        }

        public void UpdateOption(Option option)
        {
            var existingOption = quizzContext.Options.Find(option.OptionID);

            if (existingOption != null)
            {
                // Update the existing option with the values from the provided option parameter
                existingOption.OptionA = option.OptionA;
                existingOption.OptionB = option.OptionB;
                existingOption.OptionC = option.OptionC;
                existingOption.OptionD = option.OptionD;

                quizzContext.SaveChanges(); // Save changes to the database
            }
            else
            {
                throw new ArgumentException("Option not found", nameof(option));
            }
        }
    }
}
