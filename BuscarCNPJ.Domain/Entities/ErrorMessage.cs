using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class ErrorMessage
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Constraints { get; set; }
    }
}
