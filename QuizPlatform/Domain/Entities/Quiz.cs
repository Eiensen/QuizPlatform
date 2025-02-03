using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities;

public class Quiz : BaseAuditableEntity
{
    [Required]
    [MaxLength(200)]
    public string? Tittle { get; set; }
}
