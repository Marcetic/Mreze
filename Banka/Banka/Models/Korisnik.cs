using System.ComponentModel.DataAnnotations;

namespace Banka.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string MaticniBroj { get; set; }

        public ICollection<Usluga> Uslugas { get; set; }

    }
}
