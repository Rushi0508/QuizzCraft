﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace QuizzCraft.Models
{
    [DataContract]
    public class Option
    {
        
        [DataMember]
        public int OptionID { get; set; }

        [DataMember]
        public string OptionA { get; set; }

        [DataMember]
        public string OptionB { get; set; }
        
        [DataMember]
        public string OptionC { get; set; }

        [DataMember]
        public string OptionD { get; set; }

    }
}
