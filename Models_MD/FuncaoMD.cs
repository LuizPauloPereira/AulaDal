using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AULADAL.Models
{
    [MetadataType(typeof(FuncaoMD))]
    public partial class FUNCAO { }

    public partial class FuncaoMD
    {
        [DisplayName("Código")]
        public int FuncaoId { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage ="Obrigatório")]
        [StringLength(5, ErrorMessage ="Máximo 5 caractéres")]
        public string Sigla { get; set; }
    }
}