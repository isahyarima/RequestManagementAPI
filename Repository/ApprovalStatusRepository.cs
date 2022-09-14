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
    public class ApprovalStatusRepository : IApprovalStatusRepository
    {
        private readonly DataContext context;
        public ApprovalStatusRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<ApprovalStatus> CreateApprovalStatusAsync(ApprovalStatusVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new ApprovalStatus
            {
                ApprovalStatusId = model.approvalStatusId,
                StatusName = model.statusName,
            };

            var persistance = context.ApprovalStatus.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new ApprovalStatus();
        }

        public async Task<bool> DeleteApprovalStatus(int approvalStatusId)
        {
            var exist = await context.ApprovalStatus.FindAsync(approvalStatusId);

            if (exist == null) throw new Exception("No Record Found!");

            context.ApprovalStatus.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<ApprovalStatusVM> GetApprovalStatus(int approvalStatusId)
        {
            return await (from x in context.ApprovalStatus
                          where x.ApprovalStatusId == approvalStatusId
                          select new ApprovalStatusVM
                          {
                              approvalStatusId = x.ApprovalStatusId,
                              statusName = x.StatusName,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ApprovalStatusVM>> GetApprovalStatus()
        {
            return await (from x in context.ApprovalStatus
                          select new ApprovalStatusVM
                          {
                              approvalStatusId = x.ApprovalStatusId,
                              statusName = x.StatusName,

                          }).OrderBy(o => o.approvalStatusId).ToListAsync();
        }



        public async Task<bool> UpdateApprovalStatus(int approvalStatusId, ApprovalStatusVM model)
        {
            var record = await context.ApprovalStatus.FindAsync(approvalStatusId);

            if (record == null) throw new Exception("No Record Found!");

            record.ApprovalStatusId = model.approvalStatusId;
            record.StatusName = model.statusName;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






