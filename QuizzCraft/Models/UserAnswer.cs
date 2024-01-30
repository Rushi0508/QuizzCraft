using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    public class UserAnswer
    {
        [DataMember]
        public int AnswerID { get; set; }

        [DataMember]
        public int AttemptID { get; set; }

        [DataMember]
        public int QuestionID { get; set; }

        [DataMember]
        public string UserResponse { get; set; }

        [DataMember]
        public QuizAttempt QuizAttempt { get; set; }

        [DataMember]
        public Question Question { get; set; }
    }
}
