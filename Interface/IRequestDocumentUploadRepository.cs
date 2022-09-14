using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestDocumentUploadRepository
    {
        Task<RequestDocumentUpload> CreateRequestDocumentUploadAsync(RequestDocumentUploadVM model);

        Task<RequestDocumentUploadVM> GetRequestDocumentUpload(int requestDocumentUploadId);

        Task<IEnumerable<RequestDocumentUploadVM>> GetRequestDocumentUpload();

        Task<bool> UpdateRequestDocumentUpload(int requestDocumentUploadId, RequestDocumentUploadVM model);

        Task<bool> DeleteRequestDocumentUpload(int requestDocumentUploadId);
    }
}



     
