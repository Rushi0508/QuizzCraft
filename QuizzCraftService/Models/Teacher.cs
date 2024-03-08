using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace QuizzCraftService.Models
{
    [DataContract]
    public class Teacher
    {
        [DataMember]
        public int TeacherId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public int CreatedQuizzes { get; set; }

        public ICollection<Quiz> CreatedQuizzesList { get; set; }

    }
}
