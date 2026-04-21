using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Shared;

[Table("Uzivatele")]
public class Uzivatel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("jmeno")]
    public string Jmeno { get; set; }

    [Column("prijmeni")]
    public string Prijmeni { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("heslo")]
    public string Heslo { get; set; } 

    [Column("role")]
    public string Role { get; set; } = "user";
    
    [Column("telefon")]
    public string? Telefon { get; set; }

    [Column("pracoviste")]
    public string? Pracoviste { get; set; }
    
    
    [JsonIgnore] 
    public List<Karta>? Karty { get; set; } = new();

    [JsonIgnore] 
    public List<Navsteva>? Navstevy { get; set; } = new();
}