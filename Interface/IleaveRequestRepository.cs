using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface ILeaveRequestRepository
    {
        Task<LeaveRequest> CreateLeaveRequestAsync(LeaveRequestVM model);

        Task<LeaveRequestVM> GetLeaveRequest(int leaveRequestId);

        Task<IEnumerable<LeaveRequestVM>> GetLeaveRequest();

        Task<bool> UpdateLeaveRequest(int leaveRequestId, LeaveRequestVM model);

        Task<bool> DeleteLeaveRequest(int leaveRequestId);
    }
}



     
