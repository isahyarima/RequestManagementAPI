using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface ILeaveTypeRepository
    {
        Task<LeaveType> CreateLeaveTypeAsync(LeaveTypeVM model);

        Task<LeaveTypeVM> GetLeaveType(int leaveTypeId);

        Task<IEnumerable<LeaveTypeVM>> GetLeaveType();

        Task<bool> UpdateLeaveType(int leaveTypeId, LeaveTypeVM model);

        Task<bool> DeleteLeaveType(int leaveTypeId);
    }
}



     
