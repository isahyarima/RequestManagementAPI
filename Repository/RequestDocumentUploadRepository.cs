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
    public class RequestDocumentUploadRepository : IRequestDocumentUploadRepository
    {
        private readonly DataContext context;
        public RequestDocumentUploadRepository(DataContext _context)
        {
            context = _context;
        }

        public async Task<RequestDocumentUpload> CreateRequestDocumentUploadAsync(RequestDocumentUploadVM model)
        {
            if (model == null) throw new Exception("No Entry Made!");

            var record = new RequestDocumentUpload
            {
                RequestUploadId = model.requestUploadId,
                DocumentTypeId = model.documentTypeId,
                FileName = model.fileName,
                FileType = model.fileType,
                FileExtention = model.fileExtention,
                FileLink = model.fileLink,
                FileData = model.fileData,
                TargetId = model.targetId,
                Description = model.description,
                DateCreated = model.dateCreated,
                ReferenceNumber = model.referenceNumber,
                IsDocumentVerified = model.isDocumentVerified,
                RequestId = model.requestId,
            };

            var persistance = context.RequestDocumentUpload.Add(record);

            if (await context.SaveChangesAsync() > 0) return persistance;

            return new RequestDocumentUpload();
        }

        public async Task<bool> DeleteRequestDocumentUpload(int requestDocumentUploadId)
        {
            var exist = await context.RequestDocumentUpload.FindAsync(requestDocumentUploadId);

            if (exist == null) throw new Exception("No Record Found!");

            context.RequestDocumentUpload.Remove(exist);

            return await context.SaveChangesAsync() > 0;
        }

        public async Task<RequestDocumentUploadVM> GetRequestDocumentUpload(int requestDocumentUploadId)
        {
            return await (from x in context.RequestDocumentUpload
                          where x.RequestUploadId == requestDocumentUploadId
                          select new RequestDocumentUploadVM
                          {
                              documentTypeId = x.DocumentTypeId,
                              fileName = x.FileName,
                              fileType = x.FileType,
                              fileExtention = x.FileExtention,
                              fileLink = x.FileLink,
                              fileData = x.FileData,
                              targetId = x.TargetId,
                              description = x.Description,
                              dateCreated = DateTime.Now,
                              referenceNumber = x.ReferenceNumber,
                              isDocumentVerified = x.IsDocumentVerified,
                              requestId = x.RequestId,

                          }).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<RequestDocumentUploadVM>> GetRequestDocumentUpload()
        {
            return await (from x in context.RequestDocumentUpload
                          select new RequestDocumentUploadVM
                          {
                              requestUploadId = x.RequestUploadId,
                              documentTypeId = x.DocumentTypeId,
                              fileName = x.FileName,
                              fileType = x.FileType,
                              fileExtention = x.FileExtention,
                              fileLink = x.FileLink,
                              fileData = x.FileData,
                              targetId = x.TargetId,
                              description = x.Description,
                              dateCreated = x.DateCreated,
                              referenceNumber = x.ReferenceNumber,
                              isDocumentVerified = x.IsDocumentVerified,
                              requestId = x.RequestId,

                          }).OrderBy(o => o.requestUploadId).ToListAsync();
        }



        public async Task<bool> UpdateRequestDocumentUpload(int requestDocumentUploadId, RequestDocumentUploadVM model)
        {
            var record = await context.RequestDocumentUpload.FindAsync(requestDocumentUploadId);

            if (record == null) throw new Exception("No Record Found!");

            record.DocumentTypeId = model.documentTypeId;
            record.FileName = model.fileName;
            record.FileType = model.fileType;
            record.FileExtention = model.fileExtention;
            record.FileLink = model.fileLink;
            record.FileData = model.fileData;
            record.TargetId = model.targetId;
            record.Description = model.description;
            record.DateCreated = DateTime.Now;
            record.ReferenceNumber = model.referenceNumber;
            record.IsDocumentVerified = model.isDocumentVerified;
            record.RequestId = model.requestId;

            return await context.SaveChangesAsync() > 0;
        }
    }
}






