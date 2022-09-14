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
    public class RequestConditionRepository : IRequestConditionRepository
    {
        private readonly DataContext context;
        public RequestConditionRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestCondition> CreateRequestConditionAsync(RequestConditionVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestCondition
            {
                RequestConditionId = model.requestConditionId,
                RequestConditionName = model.requestConditionName,
                RequestTypeId = model.requestTypeId,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestCondition.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestCondition();
        }

        public async Task<bool> DeleteRequestCondition(int requestConditionId)
        {
            var exist = await context.RequestCondition.FindAsync(requestConditionId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestCondition.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestConditionVM> GetRequestCondition(int requestConditionId)
        {
            return await (from x in context.RequestCondition
                          where x.RequestConditionId == requestConditionId
                          select new RequestConditionVM
                          {
                              requestConditionId = x.RequestConditionId,
                              requestConditionName = x.RequestConditionName,
                              requestTypeId = x.RequestTypeId,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestConditionVM>> GetRequestCondition()
        {
            return await (from x in context.RequestCondition
                          select new RequestConditionVM
                          {
                              requestConditionId = x.RequestConditionId,
                              requestConditionName = x.RequestConditionName,
                              requestTypeId = x.RequestTypeId,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestConditionId).ToListAsync();
        }



        public async Task<bool> UpdateRequestCondition(int requestConditionId, RequestConditionVM model)
        {
            var record = await context.RequestCondition.FindAsync(requestConditionId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestConditionName = model.requestConditionName;
            record.RequestTypeId = model.requestTypeId;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






