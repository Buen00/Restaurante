using restaurante.domain.Entities;

namespace restaurante.repository.Interfaces
{
    public interface IRestauranteRepository : IBaseRepository<Restaurante>
    {
        Restaurante GetMenorConsumo();
        Restaurante GetMaiorConsumo();
    }
}