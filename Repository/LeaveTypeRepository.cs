using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly DataContext context;
        public LeaveTypeRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<LeaveType> CreateLeaveTypeAsync(LeaveTypeVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new LeaveType
            {
                LeaveTypeId = model.leaveTypeId,
                LeaveTypeName = model.leaveTypeName,
            };

            var persistance = context.LeaveType.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new LeaveType();
        }

        public async Task<bool> DeleteLeaveType(int leaveTypeId)
        {
            var exist = await context.LeaveType.FindAsync(leaveTypeId);

            if (exist == null) throw new Exception("No Record Found!");

            context.LeaveType.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<LeaveTypeVM> GetLeaveType(int leaveTypeId)
        {
            return await (from x in context.LeaveType
                          where x.LeaveTypeId == leaveTypeId
                          select new LeaveTypeVM
                          {
                              leaveTypeId = x.LeaveTypeId,
                              leaveTypeName = x.LeaveTypeName,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<LeaveTypeVM>> GetLeaveType()
        {
            return await (from x in context.LeaveType
                          select new LeaveTypeVM
                          {
                              leaveTypeId = x.LeaveTypeId,
                              leaveTypeName = x.LeaveTypeName,

                          }).OrderBy(o => o.leaveTypeId).ToListAsync();
        }



        public async Task<bool> UpdateLeaveType(int leaveTypeId, LeaveTypeVM model)
        {
            var record = await context.LeaveType.FindAsync(leaveTypeId);

            if (record == null) throw new Exception("No Record Found!");

            record.LeaveTypeName = model.leaveTypeName;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






