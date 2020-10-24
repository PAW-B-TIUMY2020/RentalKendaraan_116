using System;
using System.Collections.Generic;

namespace RentalKendaraan_116.Models
{
    public partial class Costumer
    {
        public Costumer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCostumer { get; set; }
        public string NamaCostumer { get; set; }
        public string Nik { get; set; }
        public string Alamat { get; set; }
        public string NoHp { get; set; }
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
