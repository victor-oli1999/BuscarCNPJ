using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class Registration
    {
        public string Number { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public bool Enabled { get; set; }
        public string StatusDate { get; set; } = string.Empty;
        public Status? Status { get; set; }
        public Type? Type { get; set; }
    }
}
