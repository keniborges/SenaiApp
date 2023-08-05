﻿using SenaiApp.Domain.Entidades;
using SenaiApp.Repository.Context;
using SenaiApp.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenaiApp.Repository.Repositories
{
	public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
	{

		public ClienteRepository(SenaiAppContext context) : base(context)
		{

		}

		public List<Cliente> PegarTodas()
		{
			return GetAll().ToList();
		}

		public Cliente SalvarCliente(Cliente cliente)
		{
			return Salvar(cliente);
		}
	}
}
