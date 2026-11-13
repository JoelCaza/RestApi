namespace RestApi.Datos;

using RestApi.Entidades;

public interface ICategoriaRepositorio
{
    Task<List<Categoria>> ObtenerTodasAsync();
    Task<Categoria?> ObtenerPorIdAsync(int id);
    Task<int> AgregarAsync(Categoria c);
    Task<int> ActualizarAsync(Categoria c);
    Task<int> EliminarAsync(int id);
    Task<int> ContarPlatosAsync(int id);
}
