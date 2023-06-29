using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Banka.Models

{
    public class Banka
    {
    [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kontakt { get; set; }
        public int Pib { get; set; }

        public ICollection<Filijala> Filijals { get; set; }


    }
}
