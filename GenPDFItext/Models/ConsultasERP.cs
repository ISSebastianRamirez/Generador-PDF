using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenPDFItext.Models
{
    public class ConsultasERP
    {
        public int Id { get; set; }
        public string Consultas { get; set; }
        public string Campos { get; set; }
        public string Filtros { get; set; }
    }
}