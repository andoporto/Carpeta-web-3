using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Data_Annotations.Models
{
    public class DemoModel
    {

        [Required(ErrorMessage = "¡Aquí todo el mundo tiene un nombre!")]
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}