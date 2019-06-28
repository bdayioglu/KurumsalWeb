using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KurumsalWeb.Entities
{
    public class ShippingDetails
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Şehir { get; set; }
        [Required]
        public string Adres { get; set; }
        [Required]
        public string Yaş { get; set; }
    }
}
