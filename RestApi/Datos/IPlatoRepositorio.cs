namespace RestApi.Datos;

using RestApi.Entidades;

public interface IPlatoRepositorio
{
    Task<List<Plato>> ObtenerTodosAsync();
    Task<Plato?> ObtenerPorIdAsync(int id);
    Task<List<Plato>> ObtenerPorCategoriaAsync(int categoriaId);
    Task<int> AgregarAsync(Plato p);
    Task<int> ActualizarAsync(Plato p);
    Task<int> EliminarAsync(int id);
}
