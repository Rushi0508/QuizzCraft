using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    public class QuizAttempt
    {
        [DataMember]
        public int AttemptID { get; set; }

        [DataMember]
        public int QuizID { get; set; }

        [DataMember]
        public int UserID { get; set; }

        [DataMember]
        public int Score { get; set; }

        [DataMember]
        public DateTime StartTime { get; set; }

        [DataMember]
        public DateTime EndTime { get; set; }

        [DataMember]
        public Quiz Quiz { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember]
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
}
