using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Karta")]
[Index(nameof(Cislo_karty), IsUnique = true)] // Takhle se v EF Core dělá [Unique]
public class Karta
{
    [Key] // Nahrazuje [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("uzivatel_id")]
    [Required] // Nahrazuje [NotNull]
    public int Uzivatel_id { get; set; }

    [Column("cislo_karty")]
    [Required]
    public string Cislo_karty { get; set; } // Změněno na string podle našeho diagramu!

    [Column("je_aktivni")]
    public int Je_aktivni { get; set; }

    [Column("platnost_do")]
    public DateTime Platnost_do { get; set; }

    [NotMapped] // Nahrazuje [Ignore]
    public bool JePlatna => Je_aktivni == 1 && Platnost_do > DateTime.Now;
}