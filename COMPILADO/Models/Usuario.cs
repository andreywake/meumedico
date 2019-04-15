using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace COMPILADO.Models
{

    [MetadataType(typeof(Usuario))]

    public  partial class Usuario
    {
    }

    public class usuariometadados
    {
        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(50,ErrorMessage ="Campo Obrigatorio")]
        public String Nome { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(30,ErrorMessage ="Campo Obrigatorio")]
        public String Usuario { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(10,ErrorMessage ="campo Obrigatorio")]
        public String Ssenha { get; set; }

        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(100,ErrorMessage ="Campo Obrigatorio")]
        public String Email { get; set; }

    }

}