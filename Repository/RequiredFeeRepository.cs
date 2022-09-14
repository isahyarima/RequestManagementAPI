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
    public class RequiredFeeRepository : IRequiredFeeRepository
    {
        private readonly DataContext context;
        public RequiredFeeRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequiredFee> CreateRequiredFeeAsync(RequiredFeeVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequiredFee
            {
                RequiredFeeId = model.requiredFeeId,
                RequestTypeId = model.requestTypeId,
                Fee = model.fee,
                IsVatApply = model.isVatApply,
                DateCreated = model.dateCreated,
            };

            var persistance = context.RequiredFee.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequiredFee();
        }

        public async Task<bool> DeleteRequiredFee(int requiredFeeId)
        {
            var exist = await context.RequiredFee.FindAsync(requiredFeeId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequiredFee.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequiredFeeVM> GetRequiredFee(int requiredFeeId)
        {
            return await (from x in context.RequiredFee
                          where x.RequiredFeeId == requiredFeeId
                          select new RequiredFeeVM
                          {
                              requiredFeeId = x.RequiredFeeId,
                              requestTypeId = x.RequestTypeId,
                              fee = x.Fee,
                              isVatApply = x.IsVatApply,
                              dateCreated = x.DateCreated,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequiredFeeVM>> GetRequiredFee()
        {
            return await (from x in context.RequiredFee
                          select new RequiredFeeVM
                          {
                              requiredFeeId = x.RequiredFeeId,
                              requestTypeId = x.RequestTypeId,
                              fee = x.Fee,
                              isVatApply = x.IsVatApply,
                              dateCreated = x.DateCreated,

                          }).OrderBy(o => o.requiredFeeId).ToListAsync();
        }



        public async Task<bool> UpdateRequiredFee(int requiredFeeId, RequiredFeeVM model)
        {
            var record = await context.RequiredFee.FindAsync(requiredFeeId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestTypeId = model.requestTypeId;
            record.Fee = model.fee;
            record.IsVatApply = model.isVatApply;
            record.DateCreated = DateTime.Now;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






