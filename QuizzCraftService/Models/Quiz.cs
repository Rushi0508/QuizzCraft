using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Models
{
    [DataContract] 
    public class Quiz
    {
        [DataMember]
        public int QuizId { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public int TeacherId { get; set; }

        public ICollection<Question> QuestionList { get; set; }
    }
}
