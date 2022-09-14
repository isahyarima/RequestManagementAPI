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
    public class RequestDescriptionRepository : IRequestDescriptionRepository
    {
        private readonly DataContext context;
        public RequestDescriptionRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestDescription> CreateRequestDescriptionAsync(RequestDescriptionVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestDescription
            {
                RequestDescriptionId = model.requestDescriptionId,
                Description = model.description,
                RequestTypeId = model.requestTypeId,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestDescription.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestDescription();
        }

        public async Task<bool> DeleteRequestDescription(int requestDescriptionId)
        {
            var exist = await context.RequestDescription.FindAsync(requestDescriptionId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestDescription.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestDescriptionVM> GetRequestDescription(int requestDescriptionId)
        {
            return await (from x in context.RequestDescription
                          where x.RequestDescriptionId == requestDescriptionId
                          select new RequestDescriptionVM
                          {
                              requestDescriptionId = x.RequestDescriptionId,
                              description = x.Description,
                              requestTypeId = x.RequestTypeId,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestDescriptionVM>> GetRequestDescription()
        {
            return await (from x in context.RequestDescription
                          select new RequestDescriptionVM
                          {
                              requestDescriptionId = x.RequestDescriptionId,
                              description = x.Description,
                              requestTypeId = x.RequestTypeId,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestDescriptionId).ToListAsync();
        }



        public async Task<bool> UpdateRequestDescription(int requestDescriptionId, RequestDescriptionVM model)
        {
            var record = await context.RequestDescription.FindAsync(requestDescriptionId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestDescriptionId = model.requestDescriptionId;
            record.Description = model.description;
            record.RequestTypeId = model.requestTypeId;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






