using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Entities
{
    public class CNPJ
    {
        public string TaxId { get; set; } = string.Empty;
        public string Updated { get; set; } = string.Empty;
        public Company? Company { get; set; }
        public string alias { get; set; } = string.Empty;
        public string Founded { get; set; } = string.Empty;
        public bool Head { get; set; }
        public string StatusDate { get; set; } = string.Empty;
        public Status? Status { get; set; }
        public Reason? Reason { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
        public MainActivity? MainActivity { get; set; }
        public List<SideActivity>? SideActivities { get; set; }
        public List<Registration>? Registrations { get; set; }
        public Address? Address { get; set; }

    }
}
