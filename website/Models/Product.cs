using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace website.Models
{
    public class Product
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength (150)]
        public int Name{ get; set; }
        [MaxLength(50)]
        public int Price { get; set; }
        [MaxLength(50)]
        public int DiscountPrice { get; set; }
        [MaxLength(200)]
        public int Img { get; set; }
        [NotMapped]
        public  IFormFile ImageFile{ get; set; }
        [MaxLength(50)]
        public int CreateDate { get; set; }
    }
}
