using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieGenreAppMVC.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Date Released")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime ReleaseDate { get; set; }
    }
}