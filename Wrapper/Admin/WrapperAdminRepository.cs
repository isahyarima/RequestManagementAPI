using Data.Domain.Model;
using Interface;
using Repository;

namespace Wrapper.Admin
{
   public class WrapperAdminRepository : IWrapperAdminRepository
    {
        private DataContext _context;

        private IApprovalStatusRepository _approvalStatus;

        private IExamRequestRepository _examRequest;

        private ILeaveRequestRepository _leaveRequest;

        private ILeaveTypeRepository _leaveType;

        private IRequestApprovalSetupRepository _requestApprovalSetup;

        private IRequestApprovalTrailRepository _requestApprovalTrail;

        private IRequestCategoryRepository _requestCategory;

        private IRequestConditionRepository _requestCondition;

        private IRequestDescriptionRepository _requestDescription;

        private IRequestDocumentUploadRepository _requestDocumentUpload;

        private IRequestFeeRepository _requestFee;

        private IRequestReasonRepository _requestReason;

        private IRequestTypeRepository _requestType;

        private IRequiredFeeRepository _requiredFee;







        public IApprovalStatusRepository ApprovalStatus
        {
            get
            {
                if (_approvalStatus == null)
                {
                    _approvalStatus = new ApprovalStatusRepository(_context);
                }

                return _approvalStatus;
            }
        }




        public IExamRequestRepository ExamRequest
        {
            get
            {
                if (_examRequest == null)
                {
                    _examRequest = new ExamRequestRepository(_context);
                }

                return _examRequest;
            }
        }




        public ILeaveRequestRepository LeaveRequest
        {
            get
            {
                if (_leaveRequest == null)
                {
                    _leaveRequest = new LeaveRequestRepository(_context);
                }

                return _leaveRequest;
            }
        }




        public ILeaveTypeRepository LeaveType
        {
            get
            {
                if (_leaveType == null)
                {
                    _leaveType = new LeaveTypeRepository(_context);
                }

                return _leaveType;
            }
        }




        public IRequestApprovalSetupRepository RequestApprovalSetup
        {
            get
            {
                if (_requestApprovalSetup == null)
                {
                    _requestApprovalSetup = new RequestApprovalSetupRepository(_context);
                }

                return _requestApprovalSetup;
            }
        }




        public IRequestApprovalTrailRepository RequestApprovalTrail
        {
            get
            {
                if (_requestApprovalTrail == null)
                {
                    _requestApprovalTrail = new RequestApprovalTrailRepository(_context);
                }

                return _requestApprovalTrail;
            }
        }




        public IRequestCategoryRepository RequestCategory
        {
            get
            {
                if (_requestCategory == null)
                {
                    _requestCategory = new RequestCategoryRepository(_context);
                }

                return _requestCategory;
            }
        }




        public IRequestConditionRepository RequestCondition
        {
            get
            {
                if (_requestCondition == null)
                {
                    _requestCondition = new RequestConditionRepository(_context);
                }

                return _requestCondition;
            }
        }




        public IRequestDescriptionRepository RequestDescription
        {
            get
            {
                if (_requestDescription == null)
                {
                    _requestDescription = new RequestDescriptionRepository(_context);
                }

                return _requestDescription;
            }
        }




        public IRequestDocumentUploadRepository RequestDocumentUpload
        {
            get
            {
                if (_requestDocumentUpload == null)
                {
                    _requestDocumentUpload = new RequestDocumentUploadRepository(_context);
                }

                return _requestDocumentUpload;
            }
        }




        public IRequestFeeRepository RequestFee
        {
            get
            {
                if (_requestFee == null)
                {
                    _requestFee = new RequestFeeRepository(_context);
                }

                return _requestFee;
            }
        }




        public IRequestReasonRepository RequestReason
        {
            get
            {
                if (_requestReason == null)
                {
                    _requestReason = new RequestReasonRepository(_context);
                }

                return _requestReason;
            }
        }




        public IRequestTypeRepository RequestType
        {
            get
            {
                if (_requestType == null)
                {
                    _requestType = new RequestTypeRepository(_context);
                }

                return _requestType;
            }
        }




        public IRequiredFeeRepository RequiredFee
        {
            get
            {
                if (_requiredFee == null)
                {
                    _requiredFee = new RequiredFeeRepository(_context);
                }

                return _requiredFee;
            }
        }



        public WrapperAdminRepository(DataContext repositoryContext)
        {
            _context = repositoryContext;
        }
    }
}
