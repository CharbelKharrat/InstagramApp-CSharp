using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositorys.Models;

[Table("Reel")]
public partial class Reel
{
    [Key]
    public int ReelId { get; set; }

    public int? ViewCount { get; set; }

    public int? LikeCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Timestamp { get; set; }

    public string? Caption { get; set; }

    public string? VideoUrl { get; set; }

    public string? CoverUrl { get; set; }

    public int? UserId { get; set; }
}
