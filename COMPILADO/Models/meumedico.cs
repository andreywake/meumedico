using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace COMPILADO.Models
{

    [MetadataType(typeof(Medicos))]

    public partial class Medicos
    {

    }
    public class Medicometadados
    {
        [Required(ErrorMessage = "Obrigatorio informar CRM")]
        [StringLength(30, ErrorMessage = "CRM invalido")]
        public String CRM { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar Nome")]
        [StringLength(80, ErrorMessage = "Obrigatorio Informar")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(100, ErrorMessage = "Endereco Invalido")]
        public String Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(60, ErrorMessage = "Obrigatorio Informar")]
        public String bairro { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(100, ErrorMessage = "Obrigatorio Informar")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        public bool TemClinica { get; set; }

        [Required(ErrorMessage = "Obrigatorio Informar")]
        [StringLength(80, ErrorMessage = "Obrigatorio Informar")]
        public String WebsiteBlog { get; set; }
    }
}