using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public string Acronym { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }
}
