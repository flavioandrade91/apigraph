﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace FuelManagerGraphQL.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        public string Placa { get; set; }

        [Required]
        public int AnoFabricacao { get; set; }  
            
        [Required]
        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }
    }
}
