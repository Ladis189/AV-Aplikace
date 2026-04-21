using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Shared;

[Table("Navstevy")]

public class Navsteva
{
    [Key] // Nahrazuje [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("uzivatel_id")]
    public int UzivatelId { get; set; }
    
    [Column("pobocka_id")]
    public int PobockaId { get; set; }
    
    [Column("cas_skenu")]
    public DateTime CasSkenu { get; set; } = DateTime.UtcNow;
    
    
    
    [ForeignKey(nameof(UzivatelId))]
    public Uzivatel? Uzivatel { get; set; }
    
    [ForeignKey(nameof(PobockaId))]
    public Pobocka? Pobocka { get; set; }
    
    
    
}