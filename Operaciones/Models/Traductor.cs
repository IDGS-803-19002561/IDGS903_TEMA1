using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Operaciones.Models
{
    public class Traductor
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a value.")]
        public string Español { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a value.")]
        public string Ingles { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a value.")]
        public string Type { get; set; }
    }
}