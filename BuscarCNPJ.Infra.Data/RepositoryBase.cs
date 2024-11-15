﻿using BuscarCNPJ.Domain.Common.Interface;
using BuscarCNPJ.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BuscarCNPJ.Infra.Data
{
    public class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private HttpClient _httpClient;
        public RepositoryBase(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<TEntity> Get(string entry)
        {
            TEntity entity = await _httpClient.GetFromJsonAsync<TEntity>(entry);

            return entity;
        }
    }
}
