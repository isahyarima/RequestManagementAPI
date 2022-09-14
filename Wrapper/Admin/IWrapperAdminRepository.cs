using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wrapper.Admin
{
    public interface IWrapperAdminRepository
    {

        IApprovalStatusRepository ApprovalStatus { get; }

        IExamRequestRepository ExamRequest { get; }

        ILeaveRequestRepository LeaveRequest { get; }

        ILeaveTypeRepository LeaveType { get; }

        IRequestApprovalSetupRepository RequestApprovalSetup { get; }

        IRequestApprovalTrailRepository RequestApprovalTrail { get; }

        IRequestCategoryRepository RequestCategory { get; }

        IRequestConditionRepository RequestCondition { get; }

        IRequestDescriptionRepository RequestDescription { get; }

        IRequestDocumentUploadRepository RequestDocumentUpload { get; }

        IRequestFeeRepository RequestFee { get; }

        IRequestReasonRepository RequestReason { get; }

        IRequestTypeRepository RequestType { get; }

        IRequiredFeeRepository RequiredFee { get; }

    }
}
