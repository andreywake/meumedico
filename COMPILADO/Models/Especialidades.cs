using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMPILADO.Models
{
    [MetadataType(typeof(Especialidades))]

    public partial class Especialidades
    {
    }

   public class Especialidadesmetadados
    {
        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(80, ErrorMessage = "Obrigatorio Informar")]
        public String Especialidades { get; set; }
    }
}