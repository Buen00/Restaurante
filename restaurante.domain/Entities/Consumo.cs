using System.Collections.Generic;

namespace restaurante.domain.Entities
{
    public class Consumo: Entity
    {

        public int id { get; set; }
        public Restaurante restaurante { get; set; }
        public decimal valor { get; set; }
        public string data { get; set; }
        public ICollection<Restaurante> restaurantes { get; set; }
    }
}