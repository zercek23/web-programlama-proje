namespace Web_Proje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUsers
    {
        public string Id { get; set; }

        [StringLength(256)]
        [Display(Name = "E-posta")]
        public string Email { get; set; }
        [Display(Name = "E-posta Onayland�")]
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }
        [Display(Name = "Telefon Numaras�")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Telefon Numaras� Do�rulama")]
        public bool PhoneNumberConfirmed { get; set; }
        [Display(Name = "�kili Do�rulama")]
        public bool TwoFactorEnabled { get; set; }
        [Display(Name = "Son Giri� Tarihi")]
        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }
        [Display(Name = "Hatal� Giri� Say�s�")]
        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Kullan�c� Ad�")]
        public string UserName { get; set; }

        [StringLength(256)]
        [Display(Name = "Kullan�c� Rol�")]
        public string UserRole { get; set; }
    }
}
