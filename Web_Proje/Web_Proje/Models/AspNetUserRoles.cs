namespace Web_Proje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AspNetUserRoles
    {
        [Display(Name = "Kullanýcý ID")]
        [Key]
        [Column(Order = 0)]
        public string UserId { get; set; }

        [Display(Name = "Rol ID")]
        [Key]
        [Column(Order = 1)]
        public string RoleId { get; set; }
    }
}
