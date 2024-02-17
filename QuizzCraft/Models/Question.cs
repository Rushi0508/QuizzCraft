using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    [DataContract]
    public class Question
    {
        [Key]
        [DataMember]
        public int QuestionID { get; set; }

        
        [DataMember]
        public int QuizID { get; set; }
        [DataMember]
        public string QuestionText { get; set; }

        [DataMember]
        public ICollection<string> Options { get; set; }

        [DataMember]
        public string CorrectAnswer { get; set; }

        /*
        [DataMember]
        public Quiz Quiz { get; set; }*/
    }
}
