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
        [Display(Name = "E-posta Onaylandý")]
        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }
        [Display(Name = "Telefon Numarasý")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Telefon Numarasý Doðrulama")]
        public bool PhoneNumberConfirmed { get; set; }
        [Display(Name = "Ýkili Doðrulama")]
        public bool TwoFactorEnabled { get; set; }
        [Display(Name = "Son Giriþ Tarihi")]
        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }
        [Display(Name = "Hatalý Giriþ Sayýsý")]
        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Kullanýcý Adý")]
        public string UserName { get; set; }

        [StringLength(256)]
        [Display(Name = "Kullanýcý Rolü")]
        public string UserRole { get; set; }
    }
}
