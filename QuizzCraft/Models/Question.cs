using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string QuestionText { get; set; }

        [DataMember]
        public string CorrectAnswer { get; set; }

        [DataMember]
        public int QuizId { get; set; }

        public virtual Option Option { get; set; } // Foreign key to Option
    }
}
