using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IRequestCategoryRepository
    {
        Task<RequestCategory> CreateRequestCategoryAsync(RequestCategoryVM model);

        Task<RequestCategoryVM> GetRequestCategory(int requestCategoryId);

        Task<IEnumerable<RequestCategoryVM>> GetRequestCategory();

        Task<bool> UpdateRequestCategory(int requestCategoryId, RequestCategoryVM model);

        Task<bool> DeleteRequestCategory(int requestCategoryId);
    }
}



     
