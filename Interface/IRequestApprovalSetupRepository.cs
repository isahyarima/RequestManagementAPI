using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestApprovalSetupRepository
    {
        Task<RequestApprovalSetup> CreateRequestApprovalSetupAsync(RequestApprovalSetupVM model);

        Task<RequestApprovalSetupVM> GetRequestApprovalSetup(int requestApprovalSetupId);

        Task<IEnumerable<RequestApprovalSetupVM>> GetRequestApprovalSetup();

        Task<bool> UpdateRequestApprovalSetup(int requestApprovalSetupId, RequestApprovalSetupVM model);

        Task<bool> DeleteRequestApprovalSetup(int requestApprovalSetupId);
    }
}



     
