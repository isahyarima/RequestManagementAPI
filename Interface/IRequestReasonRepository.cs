using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestReasonRepository
    {
        Task<RequestReason> CreateRequestReasonAsync(RequestReasonVM model);

        Task<RequestReasonVM> GetRequestReason(int requestReasonId);

        Task<IEnumerable<RequestReasonVM>> GetRequestReason();

        Task<bool> UpdateRequestReason(int requestReasonId, RequestReasonVM model);

        Task<bool> DeleteRequestReason(int requestReasonId);
    }
}



     
