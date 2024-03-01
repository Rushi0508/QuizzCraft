using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace QuizzCraft.Models
{

    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        public ICollection<Quiz> AttemptedQuizzes { get; set; }

        /*
        [DataMember]
        public int AttemptedQuizzes { get; set; }

        [DataMember]
        public int Points { get; set; }*/
    }
}
