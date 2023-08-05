using SenaiApp.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Service.Interfaces
{
	public interface IClienteService
	{
		Cliente Salvar(Cliente cliente);
	}
}
