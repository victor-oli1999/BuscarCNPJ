using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Jurisdiction { get; set; } = string.Empty;
        public float Equity { get; set; }
        public Nature? Nature { get; set; }
        public Size? Size { get; set; }
        public Simples? Simples { get; set; }
        public Simei? Simei { get; set; }
        public List<Members>? Members { get; set; }

    }
}
