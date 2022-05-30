using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly_Clone.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public int NumberInStock { get; set; }

        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }


    }

    
}