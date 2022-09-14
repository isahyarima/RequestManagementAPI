using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestApprovalTrailRepository
    {
        Task<RequestApprovalTrail> CreateRequestApprovalTrailAsync(RequestApprovalTrailVM model);

        Task<RequestApprovalTrailVM> GetRequestApprovalTrail(int requestApprovalTrailId);

        Task<IEnumerable<RequestApprovalTrailVM>> GetRequestApprovalTrail();

        Task<bool> UpdateRequestApprovalTrail(int requestApprovalTrailId, RequestApprovalTrailVM model);

        Task<bool> DeleteRequestApprovalTrail(int requestApprovalTrailId);
    }
}



     
