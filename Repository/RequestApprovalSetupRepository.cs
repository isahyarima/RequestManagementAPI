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
    public class RequestApprovalSetupRepository : IRequestApprovalSetupRepository
    {
        private readonly DataContext context;
        public RequestApprovalSetupRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestApprovalSetup> CreateRequestApprovalSetupAsync(RequestApprovalSetupVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestApprovalSetup
            {
                RequestApprovalSetupId = model.requestApprovalSetupId,
                RequestTypeId = model.requestTypeId,
                EmployeeId = model.employeeId,
                ApprovalOrder = model.approvalOrder,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestApprovalSetup.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestApprovalSetup();
        }

        public async Task<bool> DeleteRequestApprovalSetup(int requestApprovalSetupId)
        {
            var exist = await context.RequestApprovalSetup.FindAsync(requestApprovalSetupId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestApprovalSetup.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestApprovalSetupVM> GetRequestApprovalSetup(int requestApprovalSetupId)
        {
            return await (from x in context.RequestApprovalSetup
                          where x.RequestApprovalSetupId == requestApprovalSetupId
                          select new RequestApprovalSetupVM
                          {
                              requestApprovalSetupId = x.RequestApprovalSetupId,
                              requestTypeId = x.RequestTypeId,
                              employeeId = x.EmployeeId,
                              approvalOrder = x.ApprovalOrder,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestApprovalSetupVM>> GetRequestApprovalSetup()
        {
            return await (from x in context.RequestApprovalSetup
                          select new RequestApprovalSetupVM
                          {
                              requestApprovalSetupId = x.RequestApprovalSetupId,
                              requestTypeId = x.RequestTypeId,
                              employeeId = x.EmployeeId,
                              approvalOrder = x.ApprovalOrder,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestApprovalSetupId).ToListAsync();
        }



        public async Task<bool> UpdateRequestApprovalSetup(int requestApprovalSetupId, RequestApprovalSetupVM model)
        {
            var record = await context.RequestApprovalSetup.FindAsync(requestApprovalSetupId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestTypeId = model.requestTypeId;
            record.EmployeeId = model.employeeId;
            record.ApprovalOrder = model.approvalOrder;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






