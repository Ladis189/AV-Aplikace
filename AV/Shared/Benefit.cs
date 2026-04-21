using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Benefity")]
public class Benefit
{
    [Key] // Nahrazuje [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }

     [Column("nazev")]
     public string Nazev { get; set; }
     
     [Column("popis_slevy")]
     public string Popis_Slevy { get; set; }
     
     [Column("lokace")]
     public string Lokace { get; set; }
     
     [Column("kategorie")]
     public string Kategorie { get; set; }
     
     [Column("obrazek_url")]
     public string Obrazek_Url { get; set; }

     [JsonIgnore] public List<OblibenyBenefit> OblibeneBenefity { get; set; } = new();
}