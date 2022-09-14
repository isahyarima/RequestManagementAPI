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
    public class RequestApprovalTrailRepository : IRequestApprovalTrailRepository
    {
        private readonly DataContext context;
        public RequestApprovalTrailRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestApprovalTrail> CreateRequestApprovalTrailAsync(RequestApprovalTrailVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestApprovalTrail
            {
                RequestApprovalTrailId = model.requestApprovalTrailId,
                RequestApprovalSetupId = model.requestApprovalSetupId,
                ApprovalStatusId = model.approvalStatusId,
                Description = model.description,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestApprovalTrail.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestApprovalTrail();
        }

        public async Task<bool> DeleteRequestApprovalTrail(int requestApprovalTrailId)
        {
            var exist = await context.RequestApprovalTrail.FindAsync(requestApprovalTrailId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestApprovalTrail.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestApprovalTrailVM> GetRequestApprovalTrail(int requestApprovalTrailId)
        {
            return await (from x in context.RequestApprovalTrail
                          where x.RequestApprovalTrailId == requestApprovalTrailId
                          select new RequestApprovalTrailVM
                          {
                              requestApprovalTrailId = x.RequestApprovalTrailId,
                              requestApprovalSetupId = x.RequestApprovalSetupId,
                              approvalStatusId = x.ApprovalStatusId,
                              description = x.Description,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestApprovalTrailVM>> GetRequestApprovalTrail()
        {
            return await (from x in context.RequestApprovalTrail
                          select new RequestApprovalTrailVM
                          {
                              requestApprovalTrailId = x.RequestApprovalTrailId,
                              requestApprovalSetupId = x.RequestApprovalSetupId,
                              approvalStatusId = x.ApprovalStatusId,
                              description = x.Description,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestApprovalTrailId).ToListAsync();
        }



        public async Task<bool> UpdateRequestApprovalTrail(int requestApprovalTrailId, RequestApprovalTrailVM model)
        {
            var record = await context.RequestApprovalTrail.FindAsync(requestApprovalTrailId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestApprovalSetupId = model.requestApprovalSetupId;
            record.ApprovalStatusId = model.approvalStatusId;
            record.Description = model.description;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






