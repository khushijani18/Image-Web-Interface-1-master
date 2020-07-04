using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Image.Models
{
    [Table("uploadimg")]
    public class uploadimage
    {
        [Key]public int ImgId { get; set; }
        public string ImgName { get; set; }
        public string ImgPath { get; set; }
        public string Status { get; set; }
    }
}