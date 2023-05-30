using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Operaciones.Models
{
    public class Search
    {
        public string Text { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }
    }
}