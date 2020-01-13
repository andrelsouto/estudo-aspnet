using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using rest_consulta.Enums;
using rest_consulta.utils;

namespace rest_consulta.Model
{
    public class Plano
    {
        
        public long Id { get; set; }
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatusPlano Status { get; set; }

        [JsonConverter(typeof(DateTimeFormatConverter), "dd/MM/yyyy HH:mm:ss")]
        public Nullable<DateTime> DataInicio { get; set; }

        public IEnumerable<Usuario> Usuarios { get; set; }

    }
}