using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Banka.Models
{
    public class Filijala
    {
        [Key]
        public int Id { get; set; }
        public string Adresa { get; set; }
        public int BrojPultova { get; set; }

        [ForeignKey("Banka")]

        public int? BankaId { get; set; }
        public Banka Banka { get; set; }

        public ICollection<Usluga> Uslugas { get; set; }

    }
}
