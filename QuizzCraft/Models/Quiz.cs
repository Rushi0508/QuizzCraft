using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    [DataContract]
    public class Quiz
    {
        [DataMember]
        public int QuizID { get; set; }

        [DataMember]
        public int CreatorID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public User Creator { get; set; }

        [DataMember]
        public ICollection<Question> Questions { get; set; }
    }
}
