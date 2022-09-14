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
    public class RequestReasonRepository : IRequestReasonRepository
    {
        private readonly DataContext context;
        public RequestReasonRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestReason> CreateRequestReasonAsync(RequestReasonVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestReason
            {
                RequestReasonId = model.requestReasonId,
                RequestReasonName = model.requestReasonName,
                RequestTypeId = model.requestTypeId,
            };

            var persistance = context.RequestReason.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestReason();
        }

        public async Task<bool> DeleteRequestReason(int requestReasonId)
        {
            var exist = await context.RequestReason.FindAsync(requestReasonId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestReason.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestReasonVM> GetRequestReason(int requestReasonId)
        {
            return await (from x in context.RequestReason
                          where x.RequestReasonId == requestReasonId
                          select new RequestReasonVM
                          {
                              requestReasonId = x.RequestReasonId,
                              requestReasonName = x.RequestReasonName,
                              requestTypeId = x.RequestTypeId,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestReasonVM>> GetRequestReason()
        {
            return await (from x in context.RequestReason
                          select new RequestReasonVM
                          {
                              requestReasonId = x.RequestReasonId,
                              requestReasonName = x.RequestReasonName,
                              requestTypeId = x.RequestTypeId,

                          }).OrderBy(o => o.requestReasonId).ToListAsync();
        }



        public async Task<bool> UpdateRequestReason(int requestReasonId, RequestReasonVM model)
        {
            var record = await context.RequestReason.FindAsync(requestReasonId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestReasonName = model.requestReasonName;
            record.RequestTypeId = model.requestTypeId;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






