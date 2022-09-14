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
    [RoutePrefix("api/v1/requestApprovalSetup")]
    [Authorize]
    public class RequestApprovalSetupController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public RequestApprovalSetupController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]RequestApprovalSetupVM model)
        {
            try
            {
              
                var result = await _wrapper.RequestApprovalSetup.CreateRequestApprovalSetupAsync(model);

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
            
                var result = await _wrapper.RequestApprovalSetup.GetRequestApprovalSetup();

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
        [Route("{requestApprovalSetupId}/requestApprovalSetupId")]
        public async Task<IHttpActionResult> Get(int requestApprovalSetupId)
        {
            try
            {   
            
                var result = await _wrapper.RequestApprovalSetup.GetRequestApprovalSetup(requestApprovalSetupId);

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
		[Route("{requestApprovalSetupId}/requestApprovalSetupId")]
        public async Task<IHttpActionResult> Update([FromBody]RequestApprovalSetupVM model, int requestApprovalSetupId)
        {
            try
            {
                var result = await _wrapper.RequestApprovalSetup.UpdateRequestApprovalSetup(requestApprovalSetupId, model);

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
		[Route("{requestApprovalSetupId}/requestApprovalSetupId")]
        public async Task<IHttpActionResult> Delete(int requestApprovalSetupId)
        {
            try
            {
                var result = await _wrapper.RequestApprovalSetup.DeleteRequestApprovalSetup(requestApprovalSetupId);

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


     
