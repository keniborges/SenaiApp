namespace SenaiApp.Repository.Interfaces
{
	public interface IGenericRepository<T> where T : class
	{
		IQueryable<T> GetAll();

		void Remover(long id);
	}
}
