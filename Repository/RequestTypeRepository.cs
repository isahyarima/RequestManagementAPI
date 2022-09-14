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
    public class RequestTypeRepository : IRequestTypeRepository
    {
        private readonly DataContext context;
        public RequestTypeRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestType> CreateRequestTypeAsync(RequestTypeVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestType
            {
                RequestTypeId = model.requestTypeId,
                RequestTypeName = model.requestTypeName,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestType.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestType();
        }

        public async Task<bool> DeleteRequestType(int requestTypeId)
        {
            var exist = await context.RequestType.FindAsync(requestTypeId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestType.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestTypeVM> GetRequestType(int requestTypeId)
        {
            return await (from x in context.RequestType
                          where x.RequestTypeId == requestTypeId
                          select new RequestTypeVM
                          {
                              requestTypeId = x.RequestTypeId,
                              requestTypeName = x.RequestTypeName,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestTypeVM>> GetRequestType()
        {
            return await (from x in context.RequestType
                          select new RequestTypeVM
                          {
                              requestTypeId = x.RequestTypeId,
                              requestTypeName = x.RequestTypeName,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestTypeId).ToListAsync();
        }

        public async Task<bool> UpdateRequestType(int requestTypeId, RequestTypeVM model)
        {
            var record = await context.RequestType.FindAsync(requestTypeId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestTypeName = model.requestTypeName;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






