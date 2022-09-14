using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestDescriptionRepository
    {
        Task<RequestDescription> CreateRequestDescriptionAsync(RequestDescriptionVM model);

        Task<RequestDescriptionVM> GetRequestDescription(int requestDescriptionId);

        Task<IEnumerable<RequestDescriptionVM>> GetRequestDescription();

        Task<bool> UpdateRequestDescription(int requestDescriptionId, RequestDescriptionVM model);

        Task<bool> DeleteRequestDescription(int requestDescriptionId);
    }
}



     
