using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Models
{
    public class Filmes
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Id { get; set; }
    }
}