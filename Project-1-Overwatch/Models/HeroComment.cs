using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project_1_Overwatch.Models
{
    [Table("HeroComments")]
    public class HeroComment
    {
        [Key]
        public int HeroCommentID { get; set; }
        public String HeroCode { get; set; }
        public int UserID { get; set; }
        public String Comment { get; set; }
        public int ParentComment { get; set; }
    }
}