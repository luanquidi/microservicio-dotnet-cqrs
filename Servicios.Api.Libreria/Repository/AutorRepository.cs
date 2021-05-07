﻿using MongoDB.Driver;
using Servicios.Api.Libreria.Core.ContextMongoDB;
using Servicios.Api.Libreria.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Servicios.Api.Libreria.Repository
{
    public class AutorRepository : IAutorRepository
    {
        private readonly IAutorContext _autorContext;
        public AutorRepository(IAutorContext autorContext)
        {
            _autorContext = autorContext;
        }

        public async Task<IEnumerable<Autor>> GetAutores()
        {
            var respuesta = await _autorContext.Autores.Find(p => true).ToListAsync();
            return respuesta;
        }
    }
}
