using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinalProject.Repositorys.Models
{
    internal class PostUserViewModel
    {
        public int PostId { get; set; }

        public int? Likes { get; set; }

        public DateTime? Date { get; set; }

        public string? Caption { get; set; }

        public string? Username { get; set; }

        public string? Url { get; set; }

        public string? ImageUrl { get; set; }
    }
}
