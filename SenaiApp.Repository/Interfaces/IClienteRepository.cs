using SenaiApp.Domain.Entidades;

namespace SenaiApp.Repository.Interfaces
{
	public interface IClienteRepository
	{
		List<Cliente> PegarTodas();

		Cliente SalvarCliente(Cliente cliente);
	}
}
