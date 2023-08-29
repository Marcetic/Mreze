using System.ComponentModel.DataAnnotations;

namespace ProjekatBanka.Models
{
    public class Korisnik
    {
        [Key]
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public string MaticniBroj { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<Usluga> Uslugas { get; set; }
    }
}
