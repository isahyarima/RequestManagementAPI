using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestConditionRepository
    {
        Task<RequestCondition> CreateRequestConditionAsync(RequestConditionVM model);

        Task<RequestConditionVM> GetRequestCondition(int requestConditionId);

        Task<IEnumerable<RequestConditionVM>> GetRequestCondition();

        Task<bool> UpdateRequestCondition(int requestConditionId, RequestConditionVM model);

        Task<bool> DeleteRequestCondition(int requestConditionId);
    }
}



     
