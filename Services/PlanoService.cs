using System;
using System.Collections.Generic;
using rest_consulta.Enums;
using rest_consulta.Model;
using rest_consulta.Repositories;

namespace rest_consulta.Services
{
    public class PlanoService : IPlanoService
    {

        private readonly IPlanoRepository _planoRepository;

        public PlanoService(IPlanoRepository planoRepository)
        {
            _planoRepository = planoRepository;
        }

        public IEnumerable<Plano> GetPlano(StatusPlano status, string cpf)
        {

            var list = _planoRepository.GetPlano(status, cpf);

            return list;
        }

        public Plano SavePlano(Plano plano)
        {
            return _planoRepository.SavePlano(plano);
        }
    }
}