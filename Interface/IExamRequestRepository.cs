using Data.Domain.Model;
using Data.TransferObject.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Interface
{
    public interface IExamRequestRepository
    {
        Task<ExamRequest> CreateExamRequestAsync(ExamRequestVM model);

        Task<ExamRequestVM> GetExamRequest(int examRequestId);

        Task<IEnumerable<ExamRequestVM>> GetExamRequest();

        Task<bool> UpdateExamRequest(int examRequestId, ExamRequestVM model);

        Task<bool> DeleteExamRequest(int examRequestId);
    }
}



     
