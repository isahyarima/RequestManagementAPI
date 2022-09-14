using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequiredFeeRepository
    {
        Task<RequiredFee> CreateRequiredFeeAsync(RequiredFeeVM model);

        Task<RequiredFeeVM> GetRequiredFee(int requiredFeeId);

        Task<IEnumerable<RequiredFeeVM>> GetRequiredFee();

        Task<bool> UpdateRequiredFee(int requiredFeeId, RequiredFeeVM model);

        Task<bool> DeleteRequiredFee(int requiredFeeId);
    }
}



     
