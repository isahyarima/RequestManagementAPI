using Data.TransferObject.ViewModel;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Wrapper.Admin;


namespace careapi.Controllers
{
    [RoutePrefix("api/v1/approvalStatus")]
    [Authorize]
    public class ApprovalStatusController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public ApprovalStatusController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]ApprovalStatusVM model)
        {
            try
            {

                var result = await _wrapper.ApprovalStatus.CreateApprovalStatusAsync(model);

                if (result != null)
                {
                     return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }

        [HttpGet]
        [Route("")]
        public async  Task<IHttpActionResult> Get()
        {
            try
            {

                var result = await _wrapper.ApprovalStatus.GetApprovalStatus();

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }

        [HttpGet]
        [Route("{approvalStatusId}/approvalStatusId")]
        public async Task<IHttpActionResult> Get(int approvalStatusId)
        {
            try
            {   
               
                var result = await _wrapper.ApprovalStatus.GetApprovalStatus(approvalStatusId);

                if (result != null)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }

        [HttpPut]
		[Route("{approvalStatusId}/approvalStatusId")]
        public async Task<IHttpActionResult> Update([FromBody]ApprovalStatusVM model, int approvalStatusId)
        {
            try
            {
                var result = await _wrapper.ApprovalStatus.UpdateApprovalStatus(approvalStatusId, model);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
             return Ok(new { response = "Record not found", success = false });
        }
        [HttpDelete]
		[Route("{approvalStatusId}/approvalStatusId")]
        public async Task<IHttpActionResult> Delete(int approvalStatusId)
        {
            try
            {
                var result = await _wrapper.ApprovalStatus.DeleteApprovalStatus(approvalStatusId);

                if (result != false)
                {
                    return Ok(new { response = result, success = true });
                }
            }
            catch (Exception ex)
            {
                return Ok( new { success = false, error = ex.Message, response = "Error has accoured trying to process your request" });
            }
            return Ok(new { response = "Record not found", success = false });
        }
    }
}


     
