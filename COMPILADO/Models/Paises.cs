using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMPILADO.Models
{
    [MetadataType(typeof(Paises))]

    public partial class Paises
    {
    }

    public class PaisesMetadados{

        [Required(ErrorMessage ="Obrigatorio Informar")]
        [StringLength(50,ErrorMessage ="Obrigatorio Informar")]
        public String Pais { get; set; }

        [Required(ErrorMessage ="Obrigatorio Informar")]
        [StringLength(2,ErrorMessage ="Obrigatorio Informar")]
        public String Sigla { get; set; }

    }


}