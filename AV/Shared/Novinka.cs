using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Novinky")]
public class Novinka
{
    [Key] // Nahrazuje [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

    [Column("titulek")]
    public string Titulek { get; set; }
    
    [Column("obsah")]
    public string Obsah { get; set; }
    
    [Column("datum_vydani")]
    public DateTime Datum_vydani { get; set; } = DateTime.UtcNow;
    
    [Column("obrazek_url")]
    public string Obrazek_Url { get; set; }

    [Column("je_aktivni")] 
    public bool Je_aktivni { get; set; } = true;
}