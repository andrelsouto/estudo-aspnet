using System.Collections.Generic;
using rest_consulta.Context;
using rest_consulta.Enums;
using rest_consulta.Model;
using MongoDB.Driver;
using System.Linq;
using System;

namespace rest_consulta.Repositories
{
    public class PlanoRepository : IPlanoRepository
    {
        
        private readonly MongoDbContext _context;

        public PlanoRepository(MongoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Plano> GetPlano(StatusPlano status, string cpf)
        {
             MongoDbContext dbContext = new MongoDbContext();
             
             var listPlano = dbContext.Planos.Find(plano => (plano.Status.Equals(status) || status.Equals(StatusPlano.Default)))
                .ToList().Where(plano => plano.Usuarios.ToList().Exists(user => user.Cpf.Equals(cpf) || cpf.Equals("")));
            
            return listPlano;
        }

        public Plano SavePlano(Plano plano)
        {
            _context.Planos.InsertOne(plano);

            return plano;
        }
    }
}