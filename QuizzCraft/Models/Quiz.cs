using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    [DataContract]
    public class Quiz
    {
        [Key]
        [DataMember]
        public int QuizID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        public  int UserID { get; set; }
    }
}
