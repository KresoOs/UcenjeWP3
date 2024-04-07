
using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public record SmjerDTORead(int Sifra, string Naziv, int? Trajanje,
        decimal? Cijena,bool? Verificiran);

    public record SmjerDTOInsertUpdate(
        [Required(ErrorMessage = "Naziv obavezno")]
        string? Naziv,
        
        [Range(30, 500, ErrorMessage = "{0} mora biti između {1} i {2}")]
        [Required(ErrorMessage = "trajanje obavezno")]
        int? Trajanje,

        [Range(0, 10000, ErrorMessage = "Vrijednost {0} mora biti između {1} i {2}")]
        decimal? Cijena, 
        bool? Verificiran);

    public record PolaznikDTORead(int Sifra, string? Ime, string? Prezime,
      string? Email, string? Oib, string? Brojugovora);

    public record PolaznikDTOInsertUpdate(
        [Required(ErrorMessage = "Ime obavezno")]
        string? Ime,
        [Required(ErrorMessage = "Prezime obavezno")]
        string? Prezime,
        [Required(ErrorMessage = "Email obavezno")]
        [EmailAddress(ErrorMessage ="Email nije dobrog formata")]
        string? Email,
        string? Oib, 
        string? Brojugovora);

    public record PredavacDTORead(int Sifra, string? Ime, string? Prezime,
        string? Email, string? Oib, string? Iban);

    public record PredavacDTOInsertUpdate([Required(ErrorMessage = "Ime obavezno")]
        string? Ime,
        [Required(ErrorMessage = "Prezime obavezno")]
        string? Prezime,
        [Required(ErrorMessage = "Email obavezno")]
        [EmailAddress(ErrorMessage ="Email nije dobrog formata")]
        string? Email,
        string? Oib, 
        string? Iban);
   
    public record GrupaDTORead( int Sifra, string? Naziv,
        string? SmjerNaziv, string? PredavacImePrezime, int Brojpolaznika, DateTime? Datumpocetka, int? Maksimalnopolaznika);
    // ako se parametar zove kao svojstvo nekog tipa u toj klasi tada uzima punu putanju klase (npr. EdunovaAPP.Models.Predavac)

    public record GrupaDTOInsertUpdate(
        [Required(ErrorMessage = "Naziv obavezno")]
        [StringLength(5, ErrorMessage = "Naziv grupe ne može imati više od 5 znakova ")]
        string? Naziv,
        [Required(ErrorMessage = "Smjer obavezno")]
        int? SmjerSifra, 
        int? PredavacSifra,
        DateTime? Datumpocetka,
        [Required(ErrorMessage = "Maksimalno polaznika obavezno")]
        [Range(0, 30, ErrorMessage = "{0} mora biti između {1} i {2}")]
        int? Maksimalnopolaznika= 0);
}
