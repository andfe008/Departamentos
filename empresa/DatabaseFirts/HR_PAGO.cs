using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace empresa.DatabaseFirts
{
    public class HR_PAGO
    {
        [Key]
        public int CODIGO { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        [MaxLength(2)]
        public string COD_EMPRESA { get; set; }
        [MaxLength(32)]
        public string COD_RUBRO_PAGO { get; set; }
        [Range(6,18)]
        public int RESULTADO { get; set; }
        public DateTime FECHA_PAGO { get; set; }
        [MaxLength(16)]
        public virtual HR_DEPARTAMENTO COD_DEPARTAMENTO { get; set; }
    }
}