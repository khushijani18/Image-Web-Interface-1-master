using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Image.Models
{
    [Table("Coordinates")]
    public class displayimage
    {
        [Key]public int ImgId { get; set; }
        public float XDimension { get; set; }
        public float YDimension { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public string Label { get; set; }
    }
}