using SenaiApp.Domain.Entidades;
using SenaiApp.Repository.Interfaces;
using SenaiApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Service.Services
{
	public class ClienteService : IClienteService
	{

		private readonly IClienteRepository _clienteRepository;

		public ClienteService(IClienteRepository clienteRepository) {
			_clienteRepository= clienteRepository;
		}	

		public Cliente Salvar(Cliente cliente)
		{
			return _clienteRepository.SalvarCliente(cliente);
		}
	}
}
