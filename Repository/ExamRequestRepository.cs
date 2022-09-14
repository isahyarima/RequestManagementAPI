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
    public class ExamRequestRepository : IExamRequestRepository
    {
        private readonly DataContext context;
        public ExamRequestRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<ExamRequest> CreateExamRequestAsync(ExamRequestVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new ExamRequest
            {
                ExamRequestId = model.examRequestId,
                StudentId = model.studentId,
                BatchId = model.batchId,
                DateCreated = model.dateCreated,
                IsApproved = model.isApproved,
                termId = model.termId,
                AcademicYearId = model.academicYearId,
            };

            var persistance = context.ExamRequest.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new ExamRequest();
        }

        public async Task<bool> DeleteExamRequest(int examRequestId)
        {
            var exist = await context.ExamRequest.FindAsync(examRequestId);

            if (exist == null) throw new Exception("No Record Found!");

            context.ExamRequest.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<ExamRequestVM> GetExamRequest(int examRequestId)
        {
            return await (from x in context.ExamRequest
                          where x.ExamRequestId == examRequestId
                          select new ExamRequestVM
                          {
                              examRequestId = x.ExamRequestId,
                              studentId = x.StudentId,
                              batchId = x.BatchId,
                              dateCreated = x.DateCreated,
                              isApproved = x.IsApproved,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ExamRequestVM>> GetExamRequest()
        {
            return await (from x in context.ExamRequest
                          select new ExamRequestVM
                          {
                              examRequestId = x.ExamRequestId,
                              studentId = x.StudentId,
                              batchId = x.BatchId,
                              dateCreated = x.DateCreated,
                              isApproved = x.IsApproved,
                              termId = x.termId,
                              academicYearId = x.AcademicYearId,

                          }).OrderBy(o => o.examRequestId).ToListAsync();
        }



        public async Task<bool> UpdateExamRequest(int examRequestId, ExamRequestVM model)
        {
            var record = await context.ExamRequest.FindAsync(examRequestId);

            if (record == null) throw new Exception("No Record Found!");

            record.StudentId = model.studentId;
            record.BatchId = model.batchId;
            record.DateCreated = DateTime.Now;
            record.IsApproved = model.isApproved;
            record.termId = model.termId;
            record.AcademicYearId = model.academicYearId;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






