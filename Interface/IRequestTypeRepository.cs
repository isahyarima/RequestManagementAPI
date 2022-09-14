using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestTypeRepository
    {
        Task<RequestType> CreateRequestTypeAsync(RequestTypeVM model);

        Task<RequestTypeVM> GetRequestType(int requestTypeId);

        Task<IEnumerable<RequestTypeVM>> GetRequestType();

        Task<bool> UpdateRequestType(int requestTypeId, RequestTypeVM model);

        Task<bool> DeleteRequestType(int requestTypeId);
    }
}



     
