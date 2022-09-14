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
    [RoutePrefix("api/v1/requestApprovalTrail")]
    [Authorize]
    public class RequestApprovalTrailController : ApiController
    {
        private readonly IWrapperAdminRepository _wrapper;
        public RequestApprovalTrailController(IWrapperAdminRepository wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpPost]
        [Route("")]
        public async Task<IHttpActionResult> Create([FromBody]RequestApprovalTrailVM model)
        {
            try
            {
               
                var result = await _wrapper.RequestApprovalTrail.CreateRequestApprovalTrailAsync(model);

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
              
                var result = await _wrapper.RequestApprovalTrail.GetRequestApprovalTrail();

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
        [Route("{requestApprovalTrailId}/requestApprovalTrailId")]
        public async Task<IHttpActionResult> Get(int requestApprovalTrailId)
        {
            try
            {   
               
                var result = await _wrapper.RequestApprovalTrail.GetRequestApprovalTrail(requestApprovalTrailId);

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
		[Route("{requestApprovalTrailId}/requestApprovalTrailId")]
        public async Task<IHttpActionResult> Update([FromBody]RequestApprovalTrailVM model, int requestApprovalTrailId)
        {
            try
            {
                var result = await _wrapper.RequestApprovalTrail.UpdateRequestApprovalTrail(requestApprovalTrailId, model);

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
		[Route("{requestApprovalTrailId}/requestApprovalTrailId")]
        public async Task<IHttpActionResult> Delete(int requestApprovalTrailId)
        {
            try
            {
                var result = await _wrapper.RequestApprovalTrail.DeleteRequestApprovalTrail(requestApprovalTrailId);

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


     
