﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Column(TypeName= "datetime2")]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        [Required]
        [MaxLength(35,ErrorMessage = "That title is to long")]
        [MinLength(2, ErrorMessage = "That title is to short")]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Director { get; set; }
        public string Genre { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }


        public virtual ICollection<MovieFormatStock> MovieFormats { get; set; }
    }
}