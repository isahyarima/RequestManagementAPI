using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestFeeRepository
    {
        Task<RequestFee> CreateRequestFeeAsync(RequestFeeVM model);

        Task<RequestFeeVM> GetRequestFee(int requestFeeId);

        Task<IEnumerable<RequestFeeVM>> GetRequestFee();

        Task<bool> UpdateRequestFee(int requestFeeId, RequestFeeVM model);

        Task<bool> DeleteRequestFee(int requestFeeId);
    }
}



     
