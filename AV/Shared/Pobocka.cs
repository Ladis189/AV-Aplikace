using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Pobocky")]

public class Pobocka
{
    [Key] // Nahrazuje [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("nazev")]
    public string Nazev { get; set; }

    [Column("adresa")]
    public string Adresa { get; set; }

    [Column("kod_pro_qr")]
    public string Kod_pro_qr { get; set; }

    [JsonIgnore] public List<Navsteva>? Navstevy { get; set; } = new();
}