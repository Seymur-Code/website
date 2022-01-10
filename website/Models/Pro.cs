using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Pro
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength (150)]
        public string Name{ get; set; }
        [MaxLength(50)]
        public string Price { get; set; }
        [MaxLength(50)]
        public string DiscountPrice { get; set; }
        [MaxLength(200)]
        public string Img { get; set; }
        [NotMapped]
        public  IFormFile ImageFile{ get; set; }
       
        public DateTime CreateDate { get; set; }
    }
}
