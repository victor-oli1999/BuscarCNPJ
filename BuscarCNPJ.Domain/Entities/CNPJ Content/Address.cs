using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class Address
    {
        public int Municipality { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public Country? Country { get; set; }
    }
}
