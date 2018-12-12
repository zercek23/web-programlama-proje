using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "Haber İçeriği")]
        public string PostContent { get; set; }
        [Display(Name = "Haber Fotoğrafı")]
        public string Img { get; set; }
    }
}