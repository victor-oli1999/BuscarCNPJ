using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class Members
    {
        public string Since { get; set; } = string.Empty;
        public Person? Person { get; set; }
        public Role? Role { get; set; }
    }
}
