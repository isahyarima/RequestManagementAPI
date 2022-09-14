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
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly DataContext context;
        public LeaveRequestRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<LeaveRequest> CreateLeaveRequestAsync(LeaveRequestVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new LeaveRequest
            {
                LeaveRequestId = model.leaveRequestId,
                LeaveTypeId = model.leaveTypeId,
                StudentId = model.studentId,
                StartDate = model.startDate,
                ResumptionDate = model.resumptionDate,
                Description = model.description,
                DateCreated = model.dateCreated,
                termId = model.termId,
                AcademicYearId = model.academicYearId,
            };

            var persistance = context.LeaveRequest.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new LeaveRequest();
        }

        public async Task<bool> DeleteLeaveRequest(int leaveRequestId)
        {
            var exist = await context.LeaveRequest.FindAsync(leaveRequestId);

            if (exist == null) throw new Exception("No Record Found!");

            context.LeaveRequest.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<LeaveRequestVM> GetLeaveRequest(int leaveRequestId)
        {
            return await (from x in context.LeaveRequest
                          where x.LeaveRequestId == leaveRequestId
                          select new LeaveRequestVM
                          {
                              leaveRequestId = x.LeaveRequestId,
                              leaveTypeId = x.LeaveTypeId,
                              studentId = x.StudentId,
                              startDate = x.StartDate,
                              resumptionDate = x.ResumptionDate,
                              description = x.Description,
                              dateCreated = x.DateCreated,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<LeaveRequestVM>> GetLeaveRequest()
        {
            return await (from x in context.LeaveRequest
                          select new LeaveRequestVM
                          {
                              leaveRequestId = x.LeaveRequestId,
                              leaveTypeId = x.LeaveTypeId,
                              studentId = x.StudentId,
                              startDate = x.StartDate,
                              resumptionDate = x.ResumptionDate,
                              description = x.Description,
                              dateCreated = x.DateCreated,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).OrderBy(o => o.leaveRequestId).ToListAsync();
        }



        public async Task<bool> UpdateLeaveRequest(int leaveRequestId, LeaveRequestVM model)
        {
            var record = await context.LeaveRequest.FindAsync(leaveRequestId);

            if (record == null) throw new Exception("No Record Found!");

            record.LeaveTypeId = model.leaveTypeId;
            record.StudentId = model.studentId;
            record.StartDate = model.startDate;
            record.ResumptionDate = model.resumptionDate;
            record.Description = model.description;
            record.DateCreated = DateTime.Now;
            record.termId = model.termId;
            record.AcademicYearId = model.academicYearId;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






