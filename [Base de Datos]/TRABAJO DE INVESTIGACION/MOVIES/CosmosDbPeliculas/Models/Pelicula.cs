using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosDbPeliculas.Models
{
    public class Pelicula
    {
        [JsonProperty(PropertyName = "id")]
        public String Id { get; set; }
        public String Categoria { get; set; }
        public String Titulo { get; set; }
        public String Director { get; set; }
        public String Estreno { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
