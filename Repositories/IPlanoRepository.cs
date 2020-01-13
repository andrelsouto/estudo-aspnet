using System;
using System.Collections.Generic;
using rest_consulta.Enums;
using rest_consulta.Model;

namespace rest_consulta.Repositories
{
    public interface IPlanoRepository
    {
         
        Plano SavePlano(Plano plano);

        IEnumerable<Plano> GetPlano(StatusPlano status, string cpf);

    }
}