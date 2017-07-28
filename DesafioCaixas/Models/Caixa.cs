using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastraCaixas.Models
{
    [Table("Caixas")]

    public class Caixa
    {
        

        public int Id { get; set; }

        [Required]
        public string Tamanho { get; set; }

        [Required]
        [Display(Name = "Tempo Criação")]        
        public DateTime TempoCriacao { get; set; }

        [Required]
        [Display(Name = "Tempo Destruição")]
        public DateTime TempoDestruicao { get; set; }

        [Required]
        public string Ordem { get; set; }

        public Caixa()
        {
            TempoCriacao = DateTime.Now;
        }
    }
}