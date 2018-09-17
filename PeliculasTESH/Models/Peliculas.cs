using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeliculasTESH.Models
{
    public class Peliculas
    {
        public int PeliculasID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        //[DurationValidation]
        public int Duration { get; set; }
        public string Classification { get; set; }
    }
    public class DurationValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int duration = (int)value;
            if (duration < 30)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public DurationValidation()
        {
            ErrorMessage = "Una pelicula debe durar más de 30 minutos";
        }
    }
}