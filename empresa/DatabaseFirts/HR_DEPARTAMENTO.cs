using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace empresa.DatabaseFirts
{
    public class HR_DEPARTAMENTO
    {
        [Key]
        [Column(Order = 1)]
        [MaxLength(2)]
        public string COD_EMPRESA { get; set; }
        [Key]
        [Column(Order = 2)]
        [MaxLength(16)]
        public string COD_DEPARTAMENTO { get; set; }

        [MaxLength(64)]
        public string NOMBRE { get; set; }
    }
}