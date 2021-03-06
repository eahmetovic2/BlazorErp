﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorErp.Entities.Models.Korisnik
{
    public class Modul : BazniModel
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(45)]
        public string Sifra { get; set; }

        [StringLength(200)]
        public string Naziv { get; set; }

        [StringLength(200)]
        public string Opis { get; set; }

        [JsonIgnore]
        public virtual ICollection<PravoObjekat> PravoObjekti { get; set; }
    }
}
