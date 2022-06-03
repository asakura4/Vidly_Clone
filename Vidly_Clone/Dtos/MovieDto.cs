﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly_Clone.Models;

namespace Vidly_Clone.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}