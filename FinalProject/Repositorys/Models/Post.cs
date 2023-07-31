using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Repositorys.Models;

[Table("Post")]
public partial class Post
{
    [Key]
    public int PostId { get; set; }

    public int? LikeCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Timestamp { get; set; }

    public string? Caption { get; set; }

    public int? UserId { get; set; }

    public string? Url { get; set; }

    public string? ImageUrl { get; set; }
}
