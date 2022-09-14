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
    public class RequestCategoryRepository : IRequestCategoryRepository
    {
        private readonly DataContext context;
        public RequestCategoryRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestCategory> CreateRequestCategoryAsync(RequestCategoryVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestCategory
            {
                RequestCategoryId = model.requestCategoryId,
                RequestTypeId = model.requestTypeId,
                RequestCategoryName = model.requestCategoryName,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequestCategory.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestCategory();
        }

        public async Task<bool> DeleteRequestCategory(int requestCategoryId)
        {
            var exist = await context.RequestCategory.FindAsync(requestCategoryId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestCategory.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestCategoryVM> GetRequestCategory(int requestCategoryId)
        {
            return await (from x in context.RequestCategory
                          where x.RequestCategoryId == requestCategoryId
                          select new RequestCategoryVM
                          {
                              requestCategoryId = x.RequestCategoryId,
                              requestTypeId = x.RequestTypeId,
                              requestCategoryName = x.RequestCategoryName,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestCategoryVM>> GetRequestCategory()
        {
            return await (from x in context.RequestCategory
                          select new RequestCategoryVM
                          {
                              requestCategoryId = x.RequestCategoryId,
                              requestTypeId = x.RequestTypeId,
                              requestCategoryName = x.RequestCategoryName,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requestCategoryId).ToListAsync();
        }



        public async Task<bool> UpdateRequestCategory(int requestCategoryId, RequestCategoryVM model)
        {
            var record = await context.RequestCategory.FindAsync(requestCategoryId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestTypeId = model.requestTypeId;
            record.RequestCategoryName = model.requestCategoryName;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






