using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Models
{
    [DataContract]
    public class Question
    {
        [DataMember]
        public int QuestionID { get; set; }

        [DataMember]
        public string QuestionText { get; set; }

        [DataMember]
        public string CorrectAnswer { get; set; }

        [DataMember]
        public string OptionA { get; set; }

        [DataMember]
        public string OptionB { get; set; }

        [DataMember]
        public string OptionC { get; set; }

        [DataMember]
        public string OptionD { get; set; }

        [DataMember]
        public int QuizId { get; set; }
        
    }
}
