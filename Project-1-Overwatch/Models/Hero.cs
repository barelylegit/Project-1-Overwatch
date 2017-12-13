using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1_Overwatch.Models
{
    [Table("Heroes")]
    public class Hero
    {
        [Key]
        public String HeroCode { get; set; }
        public String HeroName { get; set; }
        public String Category { get; set; }
        public String Image { get; set; }
        public String Strengths { get; set; }
        public String Weaknesses { get; set; }
        public String Counters { get; set; }
        public String Counteredby { get; set; }
        public String Synergy { get; set; }
        public String Discord { get; set; }
        public String Description { get; set; }
    }
}