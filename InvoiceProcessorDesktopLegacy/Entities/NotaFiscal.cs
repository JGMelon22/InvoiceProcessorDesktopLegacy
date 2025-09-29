using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceProcessorDesktopLegacy.Entities
{
    [Table("NotasFiscais")]
    public class NotaFiscal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJPrestador { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJTomador { get; set; }

        [Required]
        public DateTime DataEmissao { get; set; }

        [Required]
        public string DescricaoServico { get; set; }

        [Required]
        public decimal ValorTotal { get; set; }
    }
}