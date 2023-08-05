using SenaiApp.Domain.Enums;

namespace SenaiApp.Domain.Entidades
{
	public class Cliente : BaseEntity
	{
		public string Nome { get; set; }

		public string Sobrenome { get; set; }

		public DateTime Nascimento { get; set; }

		public SexoEnum Sexo { get; set; }
	}
}
