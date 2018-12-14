using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Proje.Models
{
    public class Post
    {
        public int PostID { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [Display(Name = "Haber Başlığı")]
        public string PostHead { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [Display(Name = "Haber Alt Başlığı")]
        public string PostSubHead { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [Display(Name = "Haber Kategorisi")]
        public string PostCategory { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        [Display(Name = "Haber İçeriği")]
        public string PostContent { get; set; }
        [Display(Name = "Haber Fotoğrafı")]
        [DataType(DataType.ImageUrl)]
        public string Img { get; set; }
    }
}