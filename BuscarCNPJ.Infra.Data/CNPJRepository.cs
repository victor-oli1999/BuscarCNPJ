using BuscarCNPJ.Domain.Entities;
using BuscarCNPJ.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Infra.Data
{
    public class CNPJRepository : RepositoryBase<CNPJ>, ICnpjRepository
    {
        public CNPJRepository(HttpClient httpClient) : base(httpClient)
        {
        }
    }
}
