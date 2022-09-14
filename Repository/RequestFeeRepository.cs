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
    public class RequestFeeRepository : IRequestFeeRepository
    {
        private readonly DataContext context;
        public RequestFeeRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestFee> CreateRequestFeeAsync(RequestFeeVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestFee
            {
                RequestFeeId = model.requestFeeId,
                RequestTypeId = model.requestTypeId,
                Fee = model.fee,
                DateCreated = model.dateCreated,
                IsApproved = model.isApproved,
                termId = model.termId,
                AcademicYearId = model.academicYearId,
            };

            var persistance = context.RequestFee.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestFee();
        }

        public async Task<bool> DeleteRequestFee(int requestFeeId)
        {
            var exist = await context.RequestFee.FindAsync(requestFeeId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestFee.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestFeeVM> GetRequestFee(int requestFeeId)
        {
            return await (from x in context.RequestFee
                          where x.RequestFeeId == requestFeeId
                          select new RequestFeeVM
                          {
                              requestFeeId = x.RequestFeeId,
                              requestTypeId = x.RequestTypeId,
                              fee = x.Fee,
                              dateCreated = x.DateCreated,
                              isApproved = x.IsApproved,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestFeeVM>> GetRequestFee()
        {
            return await (from x in context.RequestFee
                          select new RequestFeeVM
                          {
                              requestFeeId = x.RequestFeeId,
                              requestTypeId = x.RequestTypeId,
                              fee = x.Fee,
                              dateCreated = x.DateCreated,
                              isApproved = x.IsApproved,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).OrderBy(o => o.requestFeeId).ToListAsync();
        }



        public async Task<bool> UpdateRequestFee(int requestFeeId, RequestFeeVM model)
        {
            var record = await context.RequestFee.FindAsync(requestFeeId);

            if (record == null) throw new Exception("No Record Found!");

            record.RequestTypeId = model.requestTypeId;
            record.Fee = model.fee;
            record.DateCreated = DateTime.Now;
            record.IsApproved = model.isApproved;
            record.termId = model.termId;
            record.AcademicYearId = model.academicYearId;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






