using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project1.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int MissionQuestion_ID { get; set; }
        public int user_ID { get; set; }
        public int mission_ID { get; set; }
        public string question { get; set; }
        public string answer { get; set; }

    }
}