using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cliente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string RazonSocial { get; set; }

    public int IdTipoCliente { get; set; }

    [Required]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;

    [Required]
    [MaxLength(50)]
    public string RFC { get; set; }
}
