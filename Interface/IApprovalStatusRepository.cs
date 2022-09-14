using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IApprovalStatusRepository
    {
        Task<ApprovalStatus> CreateApprovalStatusAsync(ApprovalStatusVM model);

        Task<ApprovalStatusVM> GetApprovalStatus(int approvalStatusId);

        Task<IEnumerable<ApprovalStatusVM>> GetApprovalStatus();

        Task<bool> UpdateApprovalStatus(int approvalStatusId, ApprovalStatusVM model);

        Task<bool> DeleteApprovalStatus(int approvalStatusId);
    }
}



     
