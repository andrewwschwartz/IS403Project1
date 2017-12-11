using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IS403Project1.Models
{
    [Table("Missions")]
 
    public class Missions
    {
        [Key]
        public int mission_ID { get; set; }
        public string missionName { get; set; }
        public string missionPresidentName { get; set; }
        public string missionAddress { get; set; }
        public string missionLanguage { get; set; }
        public string missionClimate { get; set; }
        public string missionDominantReligion { get; set; }
        public string missionFlag { get; set; }

    }
}