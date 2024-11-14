using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Domain.Common.Interface
{
    public interface IRepository<TEntity> 
        where TEntity : class
    {
        Task<TEntity> Get(string entity);
        Task<TDestination> Get<TDestination>(string entity);
    }
}
