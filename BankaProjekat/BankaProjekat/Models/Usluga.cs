using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BankaProjekat.Models
{
    public class Usluga
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string OpisUsluge { get; set; }
        public string Provizija { get; set; }

        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }

        public Korisnik Korisnik { get; set; }

        [ForeignKey("Filijala")]
        public int FilijalaId { get; set; }
        public Filijala Filijala { get; set; }
    }
}
