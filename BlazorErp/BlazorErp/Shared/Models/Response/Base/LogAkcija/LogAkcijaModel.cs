﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorErp.Shared.Models.Response.LogAkcija
{
    public class LogAkcijaModel
    {
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }
        public string Level { get; set; }
        public string Kategorija { get; set; }
        public string Akcija { get; set; }
        public DateTime DatumAkcije { get; set; }
        public string Opis { get; set; }
    }
}
