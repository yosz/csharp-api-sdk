using FortnoxAPILibrary.Entities;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ISalaryTransactionConnector : IEntityConnector
	{


		SalaryTransaction Update(SalaryTransaction salaryTransaction);
		SalaryTransaction Create(SalaryTransaction salaryTransaction);
		SalaryTransaction Get(long? id);
		void Delete(long? id);
		EntityCollection<SalaryTransactionSubset> Find(SalaryTransactionSearch searchSettings);

		Task<SalaryTransaction> UpdateAsync(SalaryTransaction salaryTransaction);
		Task<SalaryTransaction> CreateAsync(SalaryTransaction salaryTransaction);
		Task<SalaryTransaction> GetAsync(long? id);
		Task DeleteAsync(long? id);
		Task<EntityCollection<SalaryTransactionSubset>> FindAsync(SalaryTransactionSearch searchSettings);
	}
}
