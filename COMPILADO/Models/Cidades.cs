using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMPILADO.Models
{
    [MetadataType(typeof(Cidades))]

    public partial class Cidades
    {

    }
    public class Cidadesmetadados
    {
        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(100, ErrorMessage = "Obrigatorio Informar")]
        public String Cidades { get; set; }
    }
}