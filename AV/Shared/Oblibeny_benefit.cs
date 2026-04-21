using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Oblibene_Benefity")]
public class OblibenyBenefit
{
    [Column("uzivatel_id")] public int Uzivatel_id { get; set; }

    [Column("benefit_id")]
    public int Benefit_id { get; set; }

    [ForeignKey(nameof(Uzivatel_id))]
    public Uzivatel? Uzivatel { get; set; }
    
    [ForeignKey(nameof(Benefit_id))]
    public Benefit? Benefit { get; set; }



}