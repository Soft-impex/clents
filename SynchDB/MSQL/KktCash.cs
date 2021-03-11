using System;
using System.Collections.Generic;

#nullable disable

namespace SynchDB.MSQL
{
    public partial class KktCash
    {
        public Guid Id { get; set; }
        public string IdOrg { get; set; }
        public string Model { get; set; }
        public string Place { get; set; }
        public DateTime? DateShop { get; set; }
        public string Zn { get; set; }
        public string Rnm { get; set; }
        public string Supplier { get; set; }
        public bool? OnService { get; set; }
        public string ServiceTarif { get; set; }
        public bool? Temporary { get; set; }
        public string PlaceShop { get; set; }
        public string Ffd { get; set; }
        public string Nds20 { get; set; }
        public bool? ParamSmoke { get; set; }
        public bool? ParamClothes { get; set; }
        public bool? ParamBoots { get; set; }
        public bool? ParamMedical { get; set; }
    }
}
