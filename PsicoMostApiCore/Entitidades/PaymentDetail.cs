
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PsicoMostApiCore.Entitidades
{
    public class PaymentDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NomeCartao { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroCartao { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string DataExpiracao { get; set; } //MM|YY

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }
    }
}
